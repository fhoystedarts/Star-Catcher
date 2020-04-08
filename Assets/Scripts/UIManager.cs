using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text totalText;
    public Text shopTotalText;
    

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
        shopTotalText.text = GameManager.instance.totalStars.ToString();
        PlayerPrefs.SetInt("TotalScore", GameManager.instance.totalStars);
        Debug.Log("Displaying Scores");
        Debug.Log(GameManager.instance.totalStars);
    }
}
