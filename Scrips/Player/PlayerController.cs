using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody characterRb;

    private Vector3 cameraForward, cameraRight;

    // Start is called before the first frame update
    void Start()
    {
        characterRb = GetComponent<Rigidbody>();

        cameraForward = Camera.main.transform.forward;
        cameraForward.y = 0;
        cameraForward = Vector3.Normalize(cameraForward);
        cameraRight = Quaternion.Euler(new Vector3(0, 90, 0)) * cameraForward;
        
    }

    // Update is called once per frame
    void Update()
    {
        Rotate();
        Move();
        if( Input.GetKeyDown( KeyCode.E ) ){
            Interact();
        }
    }

    public void Rotate(){
         // Generate a plane that intersects the transform's position with an upwards normal.
        Plane playerPlane = new Plane(Vector3.up, transform.position);

        // Generate a ray from the cursor position
        Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);

        // Determine the point where the cursor ray intersects the plane.
	    // This will be the point that the object must look towards to be looking at the mouse.
	    // Raycasting to a Plane object only gives us a distance, so we'll have to take the distance,
	    // then find the point along that ray that meets that distance.  This will be the point
	    // to look at.
        float hitdist = 0.0f;

        // If the ray is parallel to the plane, Raycast will return false.
        if (playerPlane.Raycast (ray, out hitdist)) 
		{
        	// Get the point along the ray that hits the calculated distance.
        	Vector3 targetPoint = ray.GetPoint(hitdist);
 
        	// Determine the target rotation.  This is the rotation if the transform looks at the target point.
        	Quaternion targetRotation = Quaternion.LookRotation(targetPoint - transform.position);
 
        	// Smoothly rotate towards the target point.
        	this.gameObject.transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, moveSpeed * Time.deltaTime);
		}
    }

    //Variáveis de movimento
    [SerializeField]
    public float moveSpeed = 10f;
    public void Move(){
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0 , vertical);
        direction =  Quaternion.AngleAxis((-1)*transform.eulerAngles.y, Vector3.up) * direction;

        transform.position += new Vector3(horizontal, 0, vertical) * moveSpeed * Time.deltaTime;
    }

    public void Interact(){
        RaycastHit hit;

        
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1.5f)){
            if ( hit.collider.gameObject.layer == LayerMask.NameToLayer("Interactable")){
                hit.collider.gameObject.GetComponent<InteractableObject>().Interact(gameObject);
            }
        }

    }

    [SerializeField]
    private int SlugCount = 0;
    [SerializeField]
    private int airSlugCount = 0;
    public bool airSlugFound = false;
    [SerializeField]
    private int fotonSlugCount = 0;
    public bool fotonSlugFound = false;
    [SerializeField]
    private int gasSlugCount = 0;
    public bool gasSlugFound = false;
    [SerializeField]
    private int waterSlugCount = 0;
    public bool waterSlugFound = false;

    public void AddSlug(){
        SlugCount+= 1;
    }
    public void LoseSlug(){
        SlugCount-= 1;
    }
    public void AddAirSlug(){
        airSlugCount+= 1;
        if(!airSlugFound){
            airSlugFound = true;
        }
    }
    public void LoseAirSlug(){
        airSlugCount-= 1;
    }
    public void AddFotonSlug(){
        fotonSlugCount+= 1;
        if(!fotonSlugFound){
            fotonSlugFound = true;
        }
    }
    public void LoseFotonSlug(){
        fotonSlugCount-= 1;
    }
    public void AddGasSlug(){
        gasSlugCount+= 1;
        if(!gasSlugFound){
            gasSlugFound = true;
        }
    }
    public void LoseGasSlug(){
        gasSlugCount-= 1;
    }
    public void AddWaterSlug(){
        waterSlugCount+= 1;
        if(!waterSlugFound){
            waterSlugFound = true;
        }
    }
    public void LoseWaterSlug(){
        waterSlugCount-= 1;
    }

    public int GetSlugCount(){
        return SlugCount;
    }
    public int GetAirSlugCount(){
        return airSlugCount;
    }
    public int GetFotonSlugCount(){
        return fotonSlugCount;
    }
    public int GetGasSlugCount(){
        return gasSlugCount;
    }
    public int GetWaterSlugCount(){
        return waterSlugCount;
    }

    public int points = 0;
    public void AddPoints(int amount){
        points += amount;
    }

    public int GetPoints(){
        return points;
    }
}
