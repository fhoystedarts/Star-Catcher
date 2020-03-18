using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
    public string nextScene;
    public string GameOverScreen;
    public Canvas pauseMenu;
    private bool paused;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;

    }

    // Update is called once per frame
    void Update()
    {
        
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

    public void LoadNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

    public void LoadGameOver()
    {
        SceneManager.LoadScene(GameOverScreen);
    }

}
