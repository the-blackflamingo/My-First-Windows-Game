using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingBall : MonoBehaviour
{
    public GameObject ball;
    public float timer;
    public GameObject Lose;
    private void Update()
    {
        timer += 1* Time.deltaTime;
        if (timer > 1.5f)
        {
            timer = 0;
            ballGen();
        } 
        
    }
  private void ballGen() {
        GameObject bal = Instantiate(ball, new Vector3(Random.Range(-8, 8), 18, 0),Quaternion.identity);
        //bal.GetComponent<Rigidbody2D>().AddForce(Vector2.Down * 100f * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Jason")
        {
            Destroy(other.gameObject);
            Lose.SetActive(true);
            GameObject.Find("death").GetComponent<AudioSource>().Play();
            GameObject.Find("BGM").GetComponent<AudioSource>().Stop();
            Time.timeScale = 0;

        }
        if (other.tag == "ground")
        {
            Destroy(this.gameObject);
        }
    }
}


