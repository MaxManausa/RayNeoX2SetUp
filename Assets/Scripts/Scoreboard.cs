using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scoreboard : MonoBehaviour
{
    public int score = 0;
    [SerializeField] private GameObject normalUI;
    [SerializeField] private GameObject menuUI;
    [SerializeField] private GameObject inGameOptions;
    [SerializeField] private GameObject BowAndArrow;
    [SerializeField] private GameObject levels;
    void Start()
    {
        GetComponent<Text>().text = "Score: " + score.ToString();
        
    }
    void Update()
    {
        //Debug.Log("Score: " + score);
        GetComponent<Text>().text = "Score: " + score.ToString();
        if (score > 9)
        {
            levels.SetActive(false);
            normalUI.SetActive(false);
            inGameOptions.SetActive(false);
            BowAndArrow.SetActive(false);
            menuUI.SetActive(true);
        }
    }
    
    public void ResetScoreboard()
    {
        score = 0;
    }

   /* public void WinnerSetUp()
    {
        if (score > 9)
        {
            level1.SetActive(false);
            normalUI.SetActive(false);
            menuUI.SetActive(true);
        }
    }
    */
}
