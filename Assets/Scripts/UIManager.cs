using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text totalText;
    

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
        
    }

    // Update is called once per frame
    void Update()
    {
        UpdateTotal();
    }
    public void UpdateScore()
    {
        scoreText.text = GameManager.instance.score.ToString();
    }

    public void UpdateTotal()
    {
        totalText.text = GameManager.instance.totalStars.ToString();
        Debug.Log("Displaying Scores");
    }
}
