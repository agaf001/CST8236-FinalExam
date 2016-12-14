using UnityEngine;
using System.Collections;

public class Movements : MonoBehaviour {

    // Use this for initialization
    
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        int speed = 10;
        float angle = 1f;
        GameObject obj = GameObject.Find("Main Camera");

        if (Input.GetKey(KeyCode.W))
        {
            obj.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            obj.transform.Translate(Vector3.back * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            obj.transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            obj.transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetAxis("Mouse X") < 0)
        {
            //Code for action on mouse moving left
            obj.transform.Rotate(Vector3.down * angle, Space.World);
        }
        if (Input.GetAxis("Mouse X") > 0)
        {
            //Code for action on mouse moving left
            obj.transform.Rotate(Vector3.up * angle, Space.World);
        }
        if (Input.GetAxis("Mouse Y") < 0)
        {
            //Code for action on mouse moving left
            obj.transform.Rotate(Vector3.right * angle, Space.World);
        }
        if (Input.GetAxis("Mouse Y") > 0)
        {
            //Code for action on mouse moving left
            obj.transform.Rotate(Vector3.left * angle, Space.World);
        }

    }
}
