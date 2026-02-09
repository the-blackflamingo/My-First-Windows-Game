using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Monitor : MonoBehaviour
{
    public GameObject monitorOff;
    public GameObject monitoron;
    public TMP_Text text;
    public GameObject bubble;
    int number=0;
    public string[] phrase;
    public bool itson;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!Battery.hasBattery && !itson)
        {
            if (other.tag == "Player")
            {
                monitorOff.SetActive(true);
            }
        }
        if (Battery.hasBattery)
        {
            monitoron.SetActive(true);
            number = 0;
            Message("");
            itson = true;
            Battery.hasBattery = false;

              
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!Battery.hasBattery)
        {
            if (other.tag == "Player")
            {
                monitorOff.SetActive(false);
            }
            
        }
        
    }

    public void Message(string Text)
    {
        bubble.SetActive(true);
        text.text = phrase[number];

    }
    public void Next()
    {
        
        if (number < phrase.Length)
        {
            text.text = phrase[number];
            number += 1;
        }
        else
        {
            number = 0;
            bubble.SetActive(false);
            SceneManager.LoadScene("Monitor");
            print("ok");
        }
    }

}
