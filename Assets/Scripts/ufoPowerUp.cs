using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufoPowerUp : MonoBehaviour
{
    public UIManager uiManager;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("yellow"))
        {
            GameManager.instance.score = GameManager.instance.score + 1;
            uiManager.UpdateScore();
        }
        else if (collision.gameObject.CompareTag("blue"))
        {
            GameManager.instance.score = GameManager.instance.score + 5;
            uiManager.UpdateScore();
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("rainbow"))
        {
            GameManager.instance.score = GameManager.instance.score + 20;
            uiManager.UpdateScore();
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("black"))
        {
            GameManager.instance.score = GameManager.instance.score - 20;
            uiManager.UpdateScore();
            collision.gameObject.SetActive(false);
        }
        else if (collision.gameObject.CompareTag("meteor") && GameManager.instance.bubbleOn == false)
        {
            GameManager.instance.health = GameManager.instance.health - 1;
            collision.gameObject.SetActive(false);
            Debug.Log("Health:" + GameManager.instance.health);
        }
    }
}
