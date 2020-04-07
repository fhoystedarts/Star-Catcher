using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public string nextScene;
    public string GameOverScreen;
    public string ShopScreen;
    public string TutorialScene;

    public Canvas pauseMenu;
    private bool paused;

    public bool tutorial;
    private int currentLvl;

    public bool winScreen;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        currentLvl = PlayerPrefs.GetInt("LvlStart");

        if (GameManager.instance.health <= 0)
        {
            Time.timeScale = 0;
            Debug.Log("You Died");
            LoadGameOver();
        }
    }

    public void PauseUnpauseGame()
    {
        if (paused == false)
        {
            paused = true;
            pauseMenu.gameObject.SetActive(true);
            Time.timeScale = 0;
            Debug.Log("GAME PAUSED");
        }

        else if (paused == true)
        {
            paused = false;
            pauseMenu.gameObject.SetActive(false);
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

    public void LoadGameOver()
    {
        SceneManager.LoadScene(GameOverScreen);
    }


    public void LoadShopScene()
    {
        SceneManager.LoadScene(ShopScreen);
    }
    public void LoadMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void LoadTutorial()
    {
        SceneManager.LoadScene(TutorialScene);
    }
    public void ExitGame()
    {
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

}
