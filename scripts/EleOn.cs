using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EleOn : MonoBehaviour
{
    public GameObject MSG;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        GameObject.Find("Elevator").GetComponent<Animator>().enabled = false;
        StartCoroutine(Ele());
    }

    private IEnumerator Ele()
    {
        yield return new WaitForSeconds(1.5f);
        MSG.SetActive(true);
    }
    public void ok()
    {
        MSG.SetActive(false);
        GameObject.Find("Elevator").GetComponent<Animator>().enabled = true;
    }
}
