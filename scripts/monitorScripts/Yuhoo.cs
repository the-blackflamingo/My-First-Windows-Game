using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yuhoo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (Timee.Win) 
        {
            GameObject.Find("escaped").GetComponent<AudioSource>().Play();
        }        
    }

}
