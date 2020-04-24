using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{
	public float timeLeft;
    private float timer;

    public Text timerText;

    public SceneChanger sceneChanger;

	void Start()
	{
		
	}

	void Update()
	{
		timeLeft -= Time.deltaTime;
        timer = Mathf.Round(timeLeft);
        UpdateTimer();
		if (timer < 0)
		{
            sceneChanger.LoadNextScene();
		}
	}

    public void UpdateTimer()
    {
        timerText.text = timer.ToString();
    }
}
