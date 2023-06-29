using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YouWon : MonoBehaviour
{
    [SerializeField] private GameObject inGameMenu;
    [SerializeField] private GameObject headtrackedUIdisplay;
    [SerializeField] private GameObject bowAndArrow;
    [SerializeField] private GameObject mainmenuUIdisplay;
        
    // Start is called before the first frame update
    void Start()
    {
        inGameMenu.SetActive(false);
        headtrackedUIdisplay.SetActive(false);
        bowAndArrow.SetActive(false);
        mainmenuUIdisplay.SetActive(true);
    }

    
}
