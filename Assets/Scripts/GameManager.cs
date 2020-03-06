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

    public Slider healthBar;


    private void Start()
    {
        score = 0;
        UpdateScore();
    }

    public void Update()
    {
   
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score:" + score.ToString();
    }
    

}
