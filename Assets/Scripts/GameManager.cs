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
