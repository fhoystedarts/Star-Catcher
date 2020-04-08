using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubblePowerUP : MonoBehaviour
{
    public int bubbleHealth = 3;

    // Update is called once per frame
    void Update()
    {
       if(bubbleHealth <= 0)
        {
            this.gameObject.SetActive(false);
            GameManager.instance.bubbleOn = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("meteor") && GameManager.instance.bubbleOn == true)
        {
            bubbleHealth = bubbleHealth - 1;
            collision.gameObject.SetActive(false);
        }
    }
}
