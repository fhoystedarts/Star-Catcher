using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] spawnItems;
    public Transform spawnPoint;
    public float minDelay = 0.1f;
    public float maxDelay = 1f;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnItems");  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnItems()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int itemIndex = Random.Range(0, spawnItems.Length);
            GameObject spawnItem = spawnItems[itemIndex];

            GameObject sitem = MF_AutoPool.Spawn(spawnItem, spawnPoint.position, spawnPoint.rotation);
        }
    }
}
