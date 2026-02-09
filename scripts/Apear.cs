using UnityEngine;
using System.Collections;
public class Apear : MonoBehaviour
{
    public GameObject Marcy;

    void Start()
    {

        StartCoroutine(Appear());
    }

    private IEnumerator Appear()
    {
        yield return new WaitForSeconds(4f);
        Marcy.transform.position = new Vector3(-7.895f, -3.51f, 0.339f);
    }
}
