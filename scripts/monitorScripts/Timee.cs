using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timee : MonoBehaviour
{
    public Text timerr;
    public GameObject win;
    public float timer;
    public static bool Win = false;
    // Start is called before the first frame update
    void Start()
    {
        timer = 30f;
    }

    // Update is called once per frame
    void Update()
    {
        timerr.text = Mathf.RoundToInt(timer).ToString();
        timer -= 1 * Time.deltaTime;
        if (timer < 0)
        {
            GameObject.Find("BGM").GetComponent<AudioSource>().Stop();
            GameObject.Find("death").GetComponent<AudioSource>().Play();
            win.SetActive(true);
            Win = true;
            Time.timeScale = 0;
        }
    }
}
