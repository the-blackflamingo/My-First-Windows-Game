using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject pausee;
    public GameObject paus;
   public void pause()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        Time.timeScale = 0;
        pausee.SetActive(true);
        paus.SetActive(false);

    }
    public void Continue()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        Time.timeScale = 1f;
        pausee.SetActive(false);
        paus.SetActive(true);
    }
    public void Exit()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        SceneManager.LoadScene("Menu");
        Destroy(GameObject.Find("Sounds"));
    }
}
