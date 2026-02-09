using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public static bool haskey=false;
    public GameObject key;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            haskey = true;
            key.SetActive(false);
            GameObject.Find("yay").GetComponent<AudioSource>().Play();
        }
    }
}
