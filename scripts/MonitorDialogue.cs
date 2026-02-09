using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MonitorDialogue : MonoBehaviour
{
    public TMP_Text text;
    public GameObject bubble;
    int number;
    public string[] phrase;
    public GameObject enter;
    
    public void Message(string Text)
    {
        bubble.SetActive(true);
        enter.SetActive(false);
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
            enter.SetActive(true);
        }
    }
    public void Startt()
    {
        SceneManager.LoadScene("Monitor");
    }
}
