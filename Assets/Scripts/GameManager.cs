using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    public Text scoreText;

    public int score;

    public int health;

    public SceneChanger sceneChanger;




    private void Start()
    {
        score = 0;
        UpdateScore();
    }

    public void Update()
    {
        if (health <= 0)
        {
            Time.timeScale = 0;
                Debug.Log("You Died");
            sceneChanger.LoadGameOver();
        }
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = score.ToString();
    }
    

}
