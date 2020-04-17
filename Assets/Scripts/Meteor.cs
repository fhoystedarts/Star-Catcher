using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D rigidbody2D;
  
    public GameObject explosionPrefab;

    public Transform spawnPos;



    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.velocity = new Vector3(-moveSpeed, rigidbody2D.velocity.y, 0f);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Instantiate(explosionPrefab, spawnPos.position, spawnPos.rotation);
            gameObject.SetActive(false);
        }
    }
}
