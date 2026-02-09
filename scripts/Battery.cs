using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public GameObject battery;
    public static bool hasBattery=false;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            GameObject.Find("yay").GetComponent<AudioSource>().Play();
            hasBattery = true;
            battery.SetActive(false);
        }
    }
}
