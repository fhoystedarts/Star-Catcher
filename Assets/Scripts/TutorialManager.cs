using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject spawner;
    public GameObject spawnItem;


    // Start is called before the first frame update
    void Start()
    {
        spawnItem.gameObject.SetActive(false);
        spawner.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Touch touch = Input.GetTouch(0);
        for (int i = 0; i< popUps.Length; i++)
        {
            if (i == popUpIndex)
            {
                popUps[popUpIndex].SetActive(true);
            }
            else
                popUps[popUpIndex].SetActive(false);
        }


        if (popUpIndex == 0)
        {
            if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved)
            {
                popUpIndex++;
                Debug.Log(popUpIndex);
            }
            
        }
        if (popUpIndex == 1)
        {

            spawnItem.gameObject.SetActive(true);
            Debug.Log("Star spawned");

            if (GameManager.instance.score == 1)
            {
                popUpIndex++;
                Debug.Log(popUpIndex);
            }
        }
        if (popUpIndex == 2)
        {
            spawner.gameObject.SetActive(true);
            FindObjectOfType<Spawner>().SpawnerOn();
            popUpIndex++;
            Debug.Log(popUpIndex);
            popUps[2].SetActive(false);

        }
        
    }
}
