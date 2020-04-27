using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public string nextScene;
    public GameObject GameOverScreen;
    public string ShopScreen;
    public string TutorialScene;

    public GameObject pauseMenu;
    private bool paused;

    public bool tutorial;
    private int currentLvl;

    public bool winScreen;

    public int tempScore;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        GameOverScreen.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        currentLvl = PlayerPrefs.GetInt("LvlStart");

        if (GameManager.instance.health <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("You Died");
            GameOverScreen.SetActive(true);
        }

        PlayerPrefs.SetInt("Score", GameManager.instance.score);
        tempScore = PlayerPrefs.GetInt("Score");
    }

    public void PauseUnpauseGame()
    {
        if (paused == false)
        {
            paused = true;
            pauseMenu.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("GAME PAUSED");
        }

        else if (paused == true)
        {
            paused = false;
            pauseMenu.SetActive(false);
            Time.timeScale = 1;
            Debug.Log("GAME UNPAUSED");
        }

    }

    public void StartGame()
    {
        if(currentLvl == 0)
        {
            LoadTutorial();
        }
        else if(currentLvl == 1)
        {
            LoadNextScene();
        }
        GameManager.instance.score = 0;
    }

    public void LoadNextScene()
    {
        PlayerPrefs.SetInt("Score", GameManager.instance.score);
        SceneManager.LoadScene(nextScene);
        if(tutorial == true)
        {
            PlayerPrefs.SetInt("LvlStart", 1);
        }
        if(winScreen == true)
        {
            GameManager.instance.AddTotalScore();
            PlayerPrefs.SetInt("TotalScore", GameManager.instance.totalStars);
        }
    }

 
    public void LoadMainMenu()
    {
        GameManager.instance.totalStars = GameManager.instance.totalStars + tempScore;
        PlayerPrefs.SetInt("TotalScore", GameManager.instance.totalStars);

        SceneManager.LoadScene(0);
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene(TutorialScene);
    }
    public void ExitGame()
    {
        GameManager.instance.totalStars = GameManager.instance.totalStars + tempScore;
        PlayerPrefs.SetInt("TotalScore", GameManager.instance.totalStars);
        Application.Quit();
    }

    public void ResetTutorial()
    {
        PlayerPrefs.SetInt("LvlStart", 0);
    }

    public void ResetStars()
    {
        PlayerPrefs.SetInt("TotalScore", 0);
    }

    public void ResetPowerUps()
    {
        PlayerPrefs.SetInt("BubbleUses", 0);
        PlayerPrefs.SetInt("UFOUses", 0);
    }

    public void ResetNets()
    {
        PlayerPrefs.SetInt("NetUpgrade", 0);
    }

}
