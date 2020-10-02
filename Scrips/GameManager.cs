using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    void Start(){
        SetRanges();
        SpawnSlugs(20);
    }
    void Update(){
        if(CycleFinished){
            StartCoroutine(CycleTime());
        }
        if( player.GetPoints() >= 6 ){
            canvas.ShowWinDisplay();
        }
    }

    [SerializeField]
    private float CycleTimer = 20f;
    private bool CycleFinished = true;
    private int randomIndex;
    IEnumerator CycleTime(){
        CycleTimer = 20f;
        CycleFinished = false;
        while(CycleTimer>0){
            CycleTimer -= Time.deltaTime;
            yield return new WaitForSeconds(Time.deltaTime);
        }
        UpdateDisplay();
        if(canvas.GetAirAmount() <= 0 || canvas.GetEnergyAmount() <= 0 || canvas.GetWaterAmount() <=0 ){
            canvas.ShowLoseDisplay();
        }
        CycleFinished = true;
        SpawnSlugs(10);
    }
    public float GetTimer(){
        return CycleTimer;
    }

    private void SpawnSlugs(int amount){
        for (int i = 0; i < amount; i++)
        {
            xAxis = Random.Range(minBound.x, maxBound.x);
            yAxis = Random.Range(minBound.y, maxBound.y);
            zAxis = Random.Range(minBound.z, maxBound.z);

            randomPosition = new Vector3(xAxis,yAxis,zAxis);
            
            randomIndex = Random.Range(0,4);
            if(randomIndex == 0){
                Instantiate(airSlugPrefab, randomPosition, Quaternion.identity);
            }else if(randomIndex == 1){
                Instantiate(fotonSlugPrefab, randomPosition, Quaternion.identity);
            }else if(randomIndex == 2){
                Instantiate(gasSlugPrefab, randomPosition, Quaternion.identity);
            }else if(randomIndex == 3){
                Instantiate(waterSlugPrefab, randomPosition, Quaternion.identity);
            }
        }
    }


    public CanvasManager canvas;
    private void UpdateDisplay(){
        canvas.UpdateEnergyDisplay(EnergyMath());
        canvas.UpdateAirDisplay(AirMath());
        canvas.UpdateWaterDisplay(WaterMath());
    }
    
    public AirPodium airPodium;
    public FotonPodium fotonPodium;
    public GasPodium gasPodium;
    public WaterPodium waterPodium;    

    private float energyFinal = -0.1f;
    public float GetEnergyFinal(){
        return energyFinal;
    }
    private void SetEnergyFinal(float amount){
        energyFinal = amount;
    }
    private float EnergyMath(){
        float energyFinal = -0.1f + airPodium.AirEnergyShare() + fotonPodium.FotonEnergyShare() + waterPodium.WaterEnergyShare();
        if (academyBuilt){
            energyFinal += 0.1f;
        }else if ( statueBuilt ){
            energyFinal += 0.1f;
        }else if ( farmBuilt ){
            energyFinal -= 0.15f;
        }else if ( ghBuilt ){
            energyFinal -= 0.2f;
        }else if ( labBuilt ){
            energyFinal -= 0.3f;
        }else if ( residencialBuilt ){
            energyFinal -= 0.35f;
        }
        SetEnergyFinal(energyFinal);
        return energyFinal;
    }

    private float airFinal = -0.1f;
    public float GetAirFinal(){
        return airFinal;
    }
    private void SetAirFinal(float amount){
        airFinal = amount;
    }
    private float AirMath(){
        float airFinal = -0.1f + fotonPodium.FotonAirShare() + airPodium.AirAirShare() + gasPodium.GasAirShare();
        if (academyBuilt){
            airFinal += 0.1f;
        }else if ( statueBuilt ){
            airFinal += 0.1f;
        }else if ( farmBuilt ){
            airFinal -= 0.15f;
        }else if ( ghBuilt ){
            airFinal += 0.2f;
        }else if ( labBuilt ){
            airFinal -= 0.3f;
        }else if ( residencialBuilt ){
            airFinal -= 0.35f;
        }
        SetAirFinal(airFinal);
        return airFinal;
    }

    private float waterFinal = -0.1f;
    public float GetWaterFinal(){
        return waterFinal;
    }
    private void SetWaterFinal(float amount){
        waterFinal = amount;
    }
    private float WaterMath(){
        float waterFinal = -0.1f + waterPodium.WaterWaterShare();
        if (academyBuilt){
            waterFinal += 0.1f;
        }else if ( statueBuilt ){
            waterFinal += 0.1f;
        }else if ( farmBuilt ){
            waterFinal += 0.15f;
        }else if ( ghBuilt ){
            waterFinal += 0.2f;
        }else if ( labBuilt ){
            waterFinal -= 0.3f;
        }else if ( residencialBuilt ){
            waterFinal -= 0.35f;
        }
        SetWaterFinal(waterFinal);
        return waterFinal;
    }

    public int GetAirSlugValue(){
        return airPodium.SlugCountInPodium();
    }
    public int GetFotonSlugValue(){
        return fotonPodium.SlugCountInPodium();
    }

    public int GetGasSlugValue(){
        return gasPodium.SlugCountInPodium();
    }

    public int GetWaterSlugValue(){
        return waterPodium.SlugCountInPodium();
    }


    public PlayerController player;
    private bool academyBuilt = false;
    private bool statueBuilt = false;
    private bool farmBuilt = false;
    private bool ghBuilt = false;
    private bool labBuilt = false;
    private bool residencialBuilt = false;
    public bool CanBuildAcademy(){
        if(airPodium.CanBuild(8) && fotonPodium.CanBuild(6) && waterPodium.CanBuild(4)){
            airPodium.ReduceSlugs(8);
            fotonPodium.ReduceSlugs(6);
            waterPodium.ReduceSlugs(4);
            player.AddPoints(1);
            academyBuilt = true;
            return true;
        }else{
            return false;
        }
    }

    public bool CanBuildStatue(){
        if(fotonPodium.CanBuild(7) && gasPodium.CanBuild(5) && waterPodium.CanBuild(3)){
            fotonPodium.ReduceSlugs(7);
            gasPodium.ReduceSlugs(5);
            waterPodium.ReduceSlugs(3);
            player.AddPoints(1);
            statueBuilt = true;
            return true;
        }else{
            return false;
        }
    }

    public bool CanBuildFarm(){
        if(airPodium.CanBuild(8) && gasPodium.CanBuild(10) && waterPodium.CanBuild(5)){
            airPodium.ReduceSlugs(8);
            gasPodium.ReduceSlugs(10);
            waterPodium.ReduceSlugs(5);
            player.AddPoints(2);
            farmBuilt = true;
            return true;
        }else{
            return false;
        }
    }

    public bool CanBuildGH(){
        if(airPodium.CanBuild(10) && fotonPodium.CanBuild(10) && waterPodium.CanBuild(20)){
            airPodium.ReduceSlugs(8);
            fotonPodium.ReduceSlugs(10);
            waterPodium.ReduceSlugs(20);
            player.AddPoints(2);
            ghBuilt = true;
            return true;
        }else{
            return false;
        }
    }

    public bool CanBuildLab(){
        if(airPodium.CanBuild(10) && fotonPodium.CanBuild(20) && gasPodium.CanBuild(15)){
            airPodium.ReduceSlugs(10);
            fotonPodium.ReduceSlugs(20);
            gasPodium.ReduceSlugs(15);
            player.AddPoints(3);
            labBuilt = true;
            return true;
        }else{
            return false;
        }
    }

    public bool CanBuildResidencial(){
        if(airPodium.CanBuild(15) && fotonPodium.CanBuild(15) && waterPodium.CanBuild(20)){
            airPodium.ReduceSlugs(15);
            fotonPodium.ReduceSlugs(15);
            waterPodium.ReduceSlugs(20);
            player.AddPoints(3);
            residencialBuilt = true;
            return true;
        }else{
            return false;
        }
    }

    [SerializeField]
    private Vector3 minBound;
    [SerializeField]
    private Vector3 maxBound;
    private float xAxis;
    private float yAxis;
    private float zAxis;
    private Vector3 randomPosition;
    public GameObject airSlugPrefab;
    public GameObject fotonSlugPrefab;
    public GameObject gasSlugPrefab;
    public GameObject waterSlugPrefab;

    private void SetRanges(){
        minBound = new Vector3(2,1,66);
        maxBound = new Vector3(85,1,120);
    }

    public void ReloadScene(){
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void QuitGame(){
        Application.Quit();
    }
}
