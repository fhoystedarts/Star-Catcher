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

    // Start is called before the first frame update
    void Start()
    {
        UpdateScore();
      

        if(GameManager.instance.bubbleUses >= 1)
        {
            bubbleGameButton.gameObject.SetActive(true);
        }
        else if(GameManager.instance.bubbleUses <= 0)
        {
            bubbleGameButton.gameObject.SetActive(false);
        }
        if(GameManager.instance.ufoUses >= 1)
        {
            ufoGameButton.gameObject.SetActive(true);
        }
        else if(GameManager.instance.ufoUses <= 0)
        {
            ufoGameButton.gameObject.SetActive(false);
        }

        bubble.gameObject.SetActive(false);
        UFO.gameObject.SetActive(false);

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

    public void UseBubble()
    {
        FindObjectOfType<BubblePowerUP>().bubbleHealth = 3;
        bubble.gameObject.SetActive(true);
        GameManager.instance.bubbleOn = true;
        GameManager.instance.bubbleUses--;
        PlayerPrefs.SetInt("BubbleUses", GameManager.instance.bubbleUses);
        Debug.Log("Bubble Activated");

    }

    public void UseUFO()
    {
        UFO.gameObject.SetActive(true);
        GameManager.instance.ufoUses--;
        PlayerPrefs.SetInt("UFOUses", GameManager.instance.ufoUses);
    }
}
