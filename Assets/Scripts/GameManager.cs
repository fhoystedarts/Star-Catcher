using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    

    [SerializeField]

    public int score;
    public int health;
    public int totalStars;
    public int bubbleUses;
    public int ufoUses;

    public bool bubbleOn;

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
                return;
        }else
        {
            instance = this;
        }
        DontDestroyOnLoad(gameObject);


    }

    private void Start()
    {
 
       FindObjectOfType<UIManager>().UpdateScore();
       

    }

    public void Update()
    {
        totalStars = PlayerPrefs.GetInt("TotalScore");
        bubbleUses = PlayerPrefs.GetInt("BubbleUses");
        ufoUses = PlayerPrefs.GetInt("UFOUses");

       
    }


    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        FindObjectOfType<UIManager>().UpdateScore();
    }

    public void AddTotalScore()
    {
        totalStars = totalStars + score;
    }
}
