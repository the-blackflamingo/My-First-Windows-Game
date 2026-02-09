using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
    
{
    public GameObject Marcy;
    void Start()
    {
        StartCoroutine(disappear());
    }
    private IEnumerator disappear()
    {
        yield return new WaitForSeconds(4f);
        Marcy.SetActive(false);
    }
}
