using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandWall : MonoBehaviour
{
    public int max = 100;
    public int num = 0;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (num < max)
        {
            GameObject axe;
            GameObject container = GameObject.Find("WallContainer");
            GameObject wall = GameObject.Find("Wall");
            Transform ptrans = wall.GetComponent<Transform>();
            Object axePreb = Resources.Load("HRR_Axe_01", typeof(GameObject));
            if (axePreb == null)
                return;
            axe = Instantiate(axePreb) as GameObject;
            axe.transform.SetParent(container.transform);
            Transform trans = axe.GetComponent<Transform>();
            trans.position = new Vector3(Random.Range(0, ptrans.localScale.x),
                Random.Range(0, ptrans.localScale.y), Random.Range(-ptrans.localScale.z / 2, ptrans.localScale.z / 2));
            num++;
        }
    }
}
