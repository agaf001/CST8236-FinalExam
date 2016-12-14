using UnityEngine;
using System.Collections;

public class goalCollider : MonoBehaviour {

    // Use this for initialization
    public AudioSource goalAudio;
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerExit(Collider collider)
    {
        Debug.Log(collider.gameObject.name + " exited the trigger!");

        Destroy(collider.gameObject);

        if (goalAudio != null)
        {
            goalAudio.Play();
        }
    }
}
