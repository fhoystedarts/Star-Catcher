using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Text scoreText;

    private int score;

    public int health;

    public int Score
    {
        get { return score; }
        set
        {
            score = value;
            scoreText.text = "Stars:" + score.ToString();

        }
    }

    private void Awake()
    {
        Score = 0;
    }
    // Start is called before the first frame update
    
}
