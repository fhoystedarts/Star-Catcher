using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialTimer : MonoBehaviour
{
    public float timeLeft;
    private float timer;

    public bool off;

    public Text timerText;
    public Image fadeOut;

    public SceneChanger sceneChanger;


    void Start()
    {
        off = true;
        UpdateTimer();
    }

    void Update()
    {
        timer = Mathf.Round(timeLeft);
        if (!off)
        {
            timeLeft -= Time.deltaTime;
            
            UpdateTimer();
            if (timer < 0)
            {
                sceneChanger.LoadNextScene();
              
            }
        }
    }

    public void UpdateTimer()
    {
        timerText.text = timer.ToString();
    }
}
