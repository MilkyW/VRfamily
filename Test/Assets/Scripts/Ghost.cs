using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {
    public float speed = 0.5f;
    public int life = 100;
    public Vector3 startposition;
    public Transform other;
    // Use this for initialization
    void Start () {
        Vector3 startposition = new Vector3(0, 100, 0);
        transform.position = startposition;
        //设置出生点（也是鬼的复活点）
	}
	
	// Update is called once per frame
	void LateUpdate () {
        
        Vector3 target;
        target = GameObject.Find("Flashlight").GetComponent<Transform>().position;
    
  
        GetComponent<Transform>().position = GetComponent<Transform>().position + (target - GetComponent<Transform>().position) * speed* Time.deltaTime;

        transform.LookAt(other);
        if (other)
        {
            float dist = Vector3.Distance(other.position, transform.position);
            if (dist <= 50)
            {
                Debug.Log("play hint music");
                //transform.position = startposition;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("you are dead");
            transform.position = startposition;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        //GetComponent<Renderer>().enabled = true;
    }
    public  void Lifedcrease()
    {
        life--;
  
        if (life <= 0)
        {
            //放鬼死亡的动画
            transform.position = startposition;
            //实际上应该根据人的位置生成todo
            life = 100;
        }
  
    }
}
