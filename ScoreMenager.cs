using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreMenager : MonoBehaviour
{

    public static int Score;
    public Text text;
    public int sumScore;

    // Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Score < 0)
        {
            Score = 0;
            text.text = "" + Score;
        }
        if (Score != sumScore)
        {
            sumScore = Score;
            SetPointsTxt(sumScore);
        }
    }
    public static void AddPoints(int pointsToAdd)
    {
        Score = Score + pointsToAdd;


    }
    public void SetPointsTxt(int points)
    {
        text.text = points.ToString();
    }
}