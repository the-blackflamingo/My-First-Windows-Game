using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        Time.timeScale = 1.0f;  
    }

    public void Begin() 
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("lv1");
    }
    public void BGMoff()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        //var colors = myButton.colors;
        //colors.normalColor = new Color(0f, 1f, 0,1f);
        GameObject.Find("BG").GetComponent<AudioSource>().volume = 0f;

    }
    public void BGMon()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        GameObject.Find("BG").GetComponent<AudioSource>().volume = 1f;
    }
    public void ClickOn()
    {
        GameObject.Find("click").GetComponent<AudioSource>().volume=1f;
        GameObject.Find("click").GetComponent<AudioSource>().Play();
    }
    public void ClickOff()
    {
        GameObject.Find("click").GetComponent<AudioSource>().volume=0f;
    }
    public void Settings()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
    }

    public void Exit()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        Application.Quit();
    }
}
