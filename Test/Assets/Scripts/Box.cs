using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Box : MonoBehaviour {
    public float speed = 0.5f;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void LateUpdate () {
        
        Vector3 target;
        target = GameObject.Find("Flashlight").GetComponent<Transform>().position;
        GetComponent<Transform>().position = GetComponent<Transform>().position + (target - GetComponent<Transform>().position) * speed* Time.deltaTime;
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
