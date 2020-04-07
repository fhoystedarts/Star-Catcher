using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    [SerializeField]
    public Text scoreText;
    public Text totalStarText;

    public int score;
    public int totalScore;

    public int health;

    public SceneChanger sceneChanger;


    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);
    }

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
