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
    }

    public void Update()
    {
        scoreText.text = "Score:" + score;
    }  
    // Start is called before the first frame update

}
