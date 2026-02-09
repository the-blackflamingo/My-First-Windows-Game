using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jason : MonoBehaviour
{
    private void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.D)) 
        {
            GameObject.Find("Jason").transform.position += new Vector3(10f*Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            GameObject.Find("Jason").transform.position -= new Vector3(10f*Time.deltaTime, 0, 0);
        }
    }
}
