using UnityEngine;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private GameObject level1;
    [SerializeField] private GameObject level2;
    [SerializeField] private GameObject level3;
    [SerializeField] private GameObject level4;
    [SerializeField] private GameObject level5;
    [SerializeField] private GameObject level6;
    [SerializeField] private GameObject level7;
    [SerializeField] private GameObject level8;
    [SerializeField] private GameObject level9;
    [SerializeField] private GameObject level10;
    [SerializeField] private GameObject level11;
    [SerializeField] private GameObject level12;

    [SerializeField] private Text levelTitleText;

    public int levelNumber;

    public void WhatsTheNumber()
    {
        if (level1.activeSelf)
        {
            levelTitleText.text = "Welcome to level 1";
            levelNumber = 1;
        }
        if (level2.activeSelf)
        {
            levelTitleText.text = "Welcome to level 2";
            levelNumber = 2;
        }
        if (level3.activeSelf)
        {
            levelTitleText.text = "Welcome to level 3";
            levelNumber = 3;
        }
        if (level4.activeSelf)
        {
            levelTitleText.text = "Welcome to level 4";
            levelNumber = 4;
        }
        if (level5.activeSelf)
        {
            levelTitleText.text = "Welcome to level 5";
            levelNumber = 5;
        }
        if (level6.activeSelf)
        {
            levelTitleText.text = "Welcome to level 6";
            levelNumber = 6;
        }
        if (level7.activeSelf)
        {
            levelTitleText.text = "Welcome to level 7";
            levelNumber = 7;
        }
        if (level8.activeSelf)
        {
            levelTitleText.text = "Welcome to level 8";
            levelNumber = 8;
        }
        if (level9.activeSelf)
        {
            levelTitleText.text = "Welcome to level 9";
            levelNumber = 9;
        }
        if (level10.activeSelf)
        {
            levelTitleText.text = "Welcome to level 10";
            levelNumber = 10;
        }
        if (level11.activeSelf)
        {
            levelTitleText.text = "Welcome to level 11";
            levelNumber = 11;
        }

        if (level12.activeSelf)
        {
            levelTitleText.text = "Welcome to level 12";
            levelNumber = 12;
        }
        else return;
    }

    public void RestartLevel()
    {
        if (levelNumber == 1)
        {
            level1.SetActive(true);
        }
        if (levelNumber == 2)
        {
            level2.SetActive(true);
        }
        if (levelNumber == 3)
        {
            level3.SetActive(true);
        }
        if (levelNumber == 4)
        {
            level4.SetActive(true);
        }
        if (levelNumber == 5)
        {
            level5.SetActive(true);
        }
        if (levelNumber == 6)
        {
            level6.SetActive(true);
        }
        if (levelNumber == 7)
        {
            level7.SetActive(true);
        }
        if (levelNumber == 8)
        {
            level8.SetActive(true);
        }
        if (levelNumber == 9)
        {
            level9.SetActive(true);
        }
        if (levelNumber == 10)
        {
            level10.SetActive(true);
        }
        if (levelNumber == 11)
        {
            level11.SetActive(true);
        }

        if (levelNumber == 12)
        {
            level12.SetActive(true);
        }
    }
    public void NextLevel()
    {
        if (levelNumber == 1)
        {
            level1.SetActive(false);
            level2.SetActive(true);
        }
        if (levelNumber == 2)
        {
            level2.SetActive(false);
            level3.SetActive(true);
        }
        if (levelNumber == 3)
        {
            level3.SetActive(false);
            level4.SetActive(true);
        }
        if (levelNumber == 4)
        {
            level4.SetActive(false);
            level5.SetActive(true);
        }
        if (levelNumber == 5)
        {
            level5.SetActive(false);
            level6.SetActive(true);
        }
        if (levelNumber == 6)
        {
            level6.SetActive(false);
            level7.SetActive(true);
        }
        if (levelNumber == 7)
        {
            level7.SetActive(false);
            level8.SetActive(true);
        }
        if (levelNumber == 8)
        {
            level8.SetActive(false);
            level9.SetActive(true);
        }
        if (levelNumber == 9)
        {
            level9.SetActive(false);
            level10.SetActive(true);
        }
        if (levelNumber == 10)
        {
            level10.SetActive(false);
            level11.SetActive(true);
        }
        if (levelNumber == 11)
        {
            level11.SetActive(false);
            level12.SetActive(true);
        }

        if (levelNumber == 12)
        {
            level12.SetActive(false);
            level1.SetActive(true);
        }
        WhatsTheNumber();
    }

    public void SetLevelsInactive()
    {
        level1.SetActive(false);
        level2.SetActive(false);
        level3.SetActive(false);
        level4.SetActive(false);
        level5.SetActive(false);
        level6.SetActive(false);
        level7.SetActive(false);
        level8.SetActive(false);
        level9.SetActive(false);
        level10.SetActive(false);
        level11.SetActive(false);
        level12.SetActive(false);
        levelNumber = 0;
    }
}