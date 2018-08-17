using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        GetComponent<Renderer>().enabled = false;
    }

    private void OnTriggerExit(Collider other)
    {
        GetComponent<Renderer>().enabled = true;
    }
}
