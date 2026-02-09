using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Status : MonoBehaviour
{
    public static bool tried=false;
    public GameObject intro;
    public void tryAgain()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Monitor");
        tried = true;
        
        
    }
    public void Exit()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("lv2");
       
    }
}
