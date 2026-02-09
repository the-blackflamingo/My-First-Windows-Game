using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Next : MonoBehaviour
{
    
    public GameObject T1;
    public GameObject T2;
    public GameObject T3;
    public GameObject T4;
    public GameObject intro;
    int num = 1;
    private void Start()
    {
        if (Status.tried)
        {
            intro.SetActive(false);
            Time.timeScale = 1f;
            GameObject.Find("BGM").GetComponent<AudioSource>().Play();
        }
        else if (!Status.tried)
        {
            Time.timeScale = 0;
        }

    }
    public void NextPage()
    {
        switch (num)
        {
            case 1:
                GameObject.Find("click").GetComponent<AudioSource>().Play();
                T1.SetActive(false);
                break;
            case 2:
                GameObject.Find("click").GetComponent<AudioSource>().Play();
                T2.SetActive(false);
                break;
            case 3:
                GameObject.Find("click").GetComponent<AudioSource>().Play();
                T3.SetActive(false);
                break;
            case 4:
                GameObject.Find("click").GetComponent<AudioSource>().Play();
                T4.SetActive(false);
                intro.SetActive(false);
                Time.timeScale = 1;
                GameObject.Find("BGM").GetComponent<AudioSource>().Play();
                break;
        }
        num += 1;
        switch (num)
        {
            case 2:
                T2.SetActive(true);
                break;
            case 3:
                T3.SetActive(true);
                break;
            case 4:
                T4.SetActive(true);
                break;
            
        }
        
    }
   

}
