using UnityEngine;

public class Elevator : MonoBehaviour
{
    public GameObject Ele;
    public GameObject Bar;
    public GameObject Bar2;
    private void Update()
    {
      if (Ele.transform.position.y > -1.60)
        {
            Bar.SetActive(true);
            Bar2.SetActive(true);
        }
        if (Ele.transform.position.y <= -1.62)
        {
            Bar.SetActive(false);
            Bar2.SetActive(false);
        }
    }
}