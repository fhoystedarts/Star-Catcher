using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public Text totalText;
    public Text shopTotalText;

    public GameObject bubbleGameButton;
    public GameObject ufoGameButton;

    public GameObject bubble;
    public GameObject UFO;

    public Test test;

    public bool level;

    // Start is called before the first frame update
    void Start()
    {
        
        UpdateTotalScore();
        UpdateScore();

        if(level)
        {
            UpdateTotal(); 
        }

        bubble.SetActive(false);
        UFO.SetActive(false);
    }

    // Update is called once per frame
    public void Update()
    {
        if (GameManager.instance.bubbleUses >= 1)
        {
            bubbleGameButton.SetActive(true);
        }
        else if (GameManager.instance.bubbleUses <= 0)
        {
            if (bubbleGameButton != null)
            {
                bubbleGameButton.SetActive(false);
            }
        }
        if (GameManager.instance.ufoUses >= 1)
        {
            ufoGameButton.SetActive(true);
        }
        else if (GameManager.instance.ufoUses <= 0)
        {
           if (ufoGameButton != null)
            {
                ufoGameButton.SetActive(false);
            }
        }
        UpdateTotalScore();

        if(totalText != null)
        {
            UpdateTotal();
        }

        if(test.ufoTL < 0)
        {
            UFO.gameObject.SetActive(false);
        }
    }
    public void UpdateScore()
    {
        scoreText.text = GameManager.instance.score.ToString();
        Debug.Log("Score Updated");
    } 

    public void UpdateTotal()
    {
        totalText.text = GameManager.instance.totalStars.ToString();
        shopTotalText.text = GameManager.instance.totalStars.ToString();
        PlayerPrefs.SetInt("TotalScore", GameManager.instance.totalStars);
        Debug.Log("Displaying Scores");
        Debug.Log(GameManager.instance.totalStars);
    }

    public void UpdateTotalScore()
    {
        PlayerPrefs.SetInt("TotalScore", GameManager.instance.totalStars);
        Debug.Log("Setting Total");
    }

    public void UseBubble()
    {
        
        bubble.SetActive(true);
        GameManager.instance.bubbleOn = true;
        GameManager.instance.bubbleUses--;
        PlayerPrefs.SetInt("BubbleUses", GameManager.instance.bubbleUses);
        Debug.Log("Bubble Activated");

    }

    public void UseUFO()
    {
        UFO.SetActive(true);
        test.off = false;
        GameManager.instance.ufoUses--;
        PlayerPrefs.SetInt("UFOUses", GameManager.instance.ufoUses);
    }

}