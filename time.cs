using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class time : MonoBehaviour
{
    public Text text;
    public float timer = 3f;
    public GameObject loseScreen;
    public GameObject winScreen;
    void Start()
    {
        text.text = timer.ToString();
    }

    
    void Update()
    {
        timer = timer - Time.deltaTime;
        string minutes = ((int)timer / 60).ToString();
        string seconds = ((float)timer % 60).ToString("f2");
        text.text = minutes +":"+seconds;
        if (timer<=0)
        {
            loseScreen.SetActive(true);
        }
    }
}
