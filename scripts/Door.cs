using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    public GameObject finish;
    public GameObject doorm;
    public GameObject Marcy;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player" && Key.haskey)
        {
            finish.SetActive(true);
            Marcy.SetActive(false);
            GameObject.Find("opened").GetComponent<AudioSource>().Play();
            Key.haskey=false;
            Battery.hasBattery = false;
            Time.timeScale = 0;

            
            
        }
        else if (other.tag == "Player" && !Key.haskey)
        {
            GameObject.Find("locked").GetComponent<AudioSource>().Play();
            doorm.SetActive(true);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player" && !Key.haskey)
        {
            doorm.SetActive(false);
        }
    }

    public void menu()
    {
        GameObject.Find("click").GetComponent<AudioSource>().Play();
        Destroy(GameObject.Find("Sounds"));
        SceneManager.LoadScene("Menu");
    }
}
