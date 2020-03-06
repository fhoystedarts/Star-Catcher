using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starChase : MonoBehaviour

{
    

  
	// Start is called before the first frame update
	void Start()
	{
       
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

}