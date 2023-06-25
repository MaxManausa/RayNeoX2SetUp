using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public int score = 0;


    void Start()
    {
        GetComponent<Text>().text = "Score: " + score.ToString();
    }
    void Update()
    {
        Debug.Log("Score: " + score);
        GetComponent<Text>().text = "Score: " + score.ToString();
    }

    public void ResetScoreboard()
    {
        score = 0;
    }
    
}
