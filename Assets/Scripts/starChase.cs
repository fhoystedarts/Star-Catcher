using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starChase : MonoBehaviour

{
    [SerializeField]
    public UIManager uiManager;
    public int netUpgrade;
    public Sprite net;
    public Sprite slvrNet;
    public Sprite gldNet;

    public Health health;

  

    // Start is called before the first frame update
    void Start()
	{
        netUpgrade = PlayerPrefs.GetInt("NetUpgrade");
        if (netUpgrade == 0)
        {
            this.GetComponent<SpriteRenderer>().sprite = net;
            GameManager.instance.health = 3;
        }
       else if(netUpgrade == 1)
        {
            this.GetComponent<SpriteRenderer>().sprite = slvrNet;
            GameManager.instance.health = 5;
        }

        else if(netUpgrade == 2)
        {
            this.GetComponent<SpriteRenderer>().sprite = gldNet;
            GameManager.instance.health = 10;
        }
	}

	// Update is called once per frame
	void Update()
	{
		//the screen has been touched

		Touch touch = Input.GetTouch(0);

		if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
		{

			Vector3 touchPosition = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 0.0f));

			transform.position = Vector3.Lerp(transform.position, new Vector3(transform.position.x, touchPosition.y, transform.position.z), Time.deltaTime * 5.0f);

			//attach to net model
			//enemy spawner 
			//meteors would have greater up velocity. Set up spawner 
			//for differnt nets, change how "powerful" the meteors are for each new new



		}

        
	}
    public void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("yellow"))
        {
            GameManager.instance.score = GameManager.instance.score + 1;
            uiManager.UpdateScore();
        }
       else if(collision.gameObject.CompareTag("blue"))
        {
            GameManager.instance.score = GameManager.instance.score + 5;
            uiManager.UpdateScore();
        }
        else if (collision.gameObject.CompareTag("rainbow"))
        {
            GameManager.instance.score = GameManager.instance.score + 20;
            uiManager.UpdateScore();
        }
        else if (collision.gameObject.CompareTag("black"))
        {
            GameManager.instance.score = GameManager.instance.score - 20;
            uiManager.UpdateScore();
        }
       else if (collision.gameObject.CompareTag("meteor")&& GameManager.instance.bubbleOn == false)
        {
            health.TakeDamage(1);
            Debug.Log("Health:" + GameManager.instance.health);
        }
    }
}