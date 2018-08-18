using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    private const float one = 0.5f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 100))
        {
            Debug.Log("pengzhuangduixiang" + hit.collider.name);
            GameObject go = GameObject.Find(hit.collider.name);
            if (go.tag == "ghost")
            {
                //go.SetActive(false);
                Ghost gst = go.GetComponent<Ghost>();
                gst.Lifedcrease();
            }
            //go.GetComponent<Renderer>().enabled = false;

        }
        //GetComponent<Transform>().Rotate(999, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<Transform>().Rotate(-one, 0, 0);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            GetComponent<Transform>().Rotate(one, 0, 0);
        }

        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<Transform>().Rotate(0, -one, 0);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            GetComponent<Transform>().Rotate(0, one, 0);
        }
    }

}
