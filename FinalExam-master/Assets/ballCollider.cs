using UnityEngine;
using System.Collections;

public class ballCollider : MonoBehaviour {

    public AudioSource sound;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider collider)
    {
        Debug.Log(collider.gameObject.name + " exited the trigger!");

        //Destroy(collider.gameObject);

        if (sound != null)
        {
            sound.Play();
        }
    }
}
