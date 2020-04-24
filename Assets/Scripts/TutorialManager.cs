using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialManager : MonoBehaviour
{
    public GameObject[] popUps;
    private int popUpIndex;
    public GameObject spawner;
    public GameObject spawnItem;
    public TutorialTimer tt;


    // Start is called before the first frame update
    void Start()
    {
        spawnItem.SetActive(false);
        spawner.SetActive(false);
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
            if (touch.phase == TouchPhase.Began)
            {
                popUpIndex++;
            }
            
        }
        if (popUpIndex == 1)
        {

            spawnItem.SetActive(true);
            Debug.Log("Star spawned");
            popUps[1].SetActive(true);

            if (GameManager.instance.score == 1)
            {
                popUpIndex++;
                popUps[1].SetActive(false);
            }
        }
        if (popUpIndex == 2)
        {
            if (touch.phase == TouchPhase.Ended)
            {
                spawner.SetActive(true);
                FindObjectOfType<Spawner>().SpawnerOn();
                popUpIndex++;
                popUps[2].SetActive(false);
                tt.off = false;
                
            }
      
        }
       
    }
}
