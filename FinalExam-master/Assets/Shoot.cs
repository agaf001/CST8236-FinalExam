using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {

    public Camera _currentCamera;
    //AudioSource _currentSource;
    Ray _lastRayCast;

    
    //private GameObject obj = GameObject.Find("EarthLow");

    // Use this for initialization
    void Start () {
        //_currentCamera = GetComponent<Camera>();
        //_currentSource = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {

        GameObject mainobj = GameObject.Find("EarthLow");
        //mainobj.name = "New";
      // if (!hitHappened)
      //obj.transform.position = _currentCamera.transform.position;

        if (Input.GetMouseButtonDown(0) == true)
        {
           GameObject obj = Instantiate(mainobj);
            obj.name = "New";
            obj.transform.position = _currentCamera.transform.position;
            // Create a ray that represent  s the 3D equivalent of our 2D position in the window frame.
            Ray clickRay = _currentCamera.ScreenPointToRay(Input.mousePosition);
            _lastRayCast = clickRay;
           

            // Play the selected sound effect.
            //_currentSource.Play();

            // This stores what we have hit with our raycast.
            // RaycastHit hit;

            // Cast the click ray into the world and see what is hit.
            // bool didHit = Physics.Raycast(clickRay, out hit);
            //if (didHit)
            //{
            Debug.Log("Hey! We hit something!");

            // Grab the GameObject we hit, and store it for later.
            //GameObject objectWeHit = hit.transform.gameObject;

            // Check to see if the object we've hit has an AudioSource..
            //AudioSource objectWeHitAudio = objectWeHit.GetComponent<AudioSource>();
            /*if (objectWeHitAudio != null)
            {
                // If so, play it!
                objectWeHitAudio.Play();
            }
            */
            // Store the distance of the last raycast.
            //_raycastDistance = hit.distance;

            //Rigidbody rb = GameObject.Find("EarthLow").rigidbody;
            Rigidbody rb = obj.GetComponent<Rigidbody>();
            // Apply a force where the ray hit the object.
            if (rb != null)
            {
                // If the object isn't using gravity, tell it to.
                rb.useGravity = true;

                    var force = _currentCamera.transform.position * -1;
                    //Vector3 explos = new Vector3( 0f, -20f, 0f);
                    Vector3 explos = new Vector3(0f, 0, 0f);
                    // Spawn an explosion where the ray hit the object.
                    // rb.AddExplosionForce(2000.0f, explos, 10.25f);
                    rb.AddForce(force * 200);
            }

           // }
        }

    }
}
