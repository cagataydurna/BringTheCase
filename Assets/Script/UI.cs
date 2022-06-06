using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject mainMenuPanel;
    public GameObject playMenu;
    public GameObject playMenuWinPanel;
    public GameObject levelSelect;
    public Text  green, purple, blue, red, total;
    public Text levelText;
    
    void Start()
    {
        mainMenu.SetActive(true);
        Time.timeScale = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        levelText.text = "Level "+(SceneManager.GetActiveScene().buildIndex).ToString();
        if (PlayerMovement._instance.isFinishForCanvas)
        {
            playMenuWinPanel.SetActive(true);
            StartCoroutine(ScoreCalculator());
        }
        
    }

    public void StartButton()
    {
        Time.timeScale = 1f;
        mainMenu.SetActive(false);
        playMenu.SetActive(true);
    }

    public void ExitButton()
    {
        Application.Quit();
    }

    public void LevelButton()
    {
        mainMenuPanel.SetActive(false);
        levelSelect.SetActive(true);
    }

    public void LevelSelectBack()
    {
        mainMenuPanel.SetActive(true);
        levelSelect.SetActive(false);
    }

    public void LevelSelect(int levelIndex)
    {
        SceneManager.LoadScene(levelIndex+1);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    IEnumerator ScoreCalculator()
    {
        for (int i = 0; i < 5; i++)
        {
            yield return new WaitForSeconds(0.3f);

            if (i == 0)
            {
                red.text = "Red " +RedCollider._instance.hittingObjectCount.ToString("0") + "X";
            }else if (i == 1)
            {
                blue.text = "Blue "+BlueCollider._instance.hittingObjectCount.ToString("0") + "X";
            }else if (i == 2)
            {
                purple.text ="Purple"+PurpleCollider._instance.hittingObjectCount.ToString("0") + "X";
                
            }else if (i == 3)
            {
                green.text = "Green"+GreenCollider._instance.hittingObjectCount.ToString("0") + "X";
                
            }

            if (i == 4)
            {
                total.text = "Total"+(GreenCollider._instance.hittingObjectCount * RedCollider._instance.hittingObjectCount *
                              PurpleCollider._instance.hittingObjectCount * BlueCollider._instance.hittingObjectCount)
                    .ToString("0");
            }
        }
        
    }
    
}
