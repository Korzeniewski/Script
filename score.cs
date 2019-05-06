using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text scored;
    public float count = 0f;
    public float win = 100f;
    public GameObject winScreen;
    public GameObject loseScreen;
    public GameObject gameMenager;
    void Start()
    {
        scored.text = count.ToString() + "/100";
    }


    void Update()
    {
        if (count == win)
        {
            winScreen.SetActive(true);
            Destroy(loseScreen);
        }
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag=="coin")
        {
            count++;
            scored.text = count.ToString() + "/100";
            Destroy(other.gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "block")
        {
            count--;
            scored.text = count.ToString() + "/100";
        }
        if (collision.gameObject.tag =="enemy")
        {
           var time = gameMenager.GetComponent<time>().timer;
            time = time - 10f;
            gameMenager.GetComponent<time>().timer = time;
        }
    }
}
