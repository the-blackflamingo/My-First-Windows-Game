using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Movement : MonoBehaviour
{
    
    public float stepInterval = 0.75f; 
    private float nextStepTime = 0f;
    void Update()
    {
        bool isMoving = false;

        if (Input.GetKey(KeyCode.D))
        {
            GetComponent<SpriteRenderer>().flipX=false;
            transform.position += new Vector3(0.045f, 0, 0);
            isMoving = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            GetComponent<SpriteRenderer>().flipX = true;
            transform.position -= new Vector3(0.045f, 0, 0);
            isMoving = true;
        }

        GetComponent<Animator>().SetInteger("Move", isMoving ? 1 : 0);

        
        if (isMoving && Time.time >= nextStepTime)
        {
            GameObject.Find("Marcy").GetComponent<AudioSource>().Play();
            nextStepTime = Time.time + stepInterval;
        }
    }
}



//scraped
//void Update()
//{
//    if (Input.GetKey(KeyCode.D))
//    {
//        GameObject.Find("walking").GetComponent<AudioSource>().Play();
//        transform.position += new Vector3(0.025f, 0, 0);
//        GetComponent<Animator>().SetInteger("Move", 1);
//    }
//    else if (Input.GetKey(KeyCode.A))
//    {
//        GameObject.Find("walking").GetComponent<AudioSource>().Play();
//        transform.position -= new Vector3(0.025f, 0, 0);
//        GetComponent<Animator>().SetInteger("Move", 1);
//    }
//    else
//    {
//        GetComponent<Animator>().SetInteger("Move", 0);
//    }
//}
