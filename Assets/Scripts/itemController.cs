using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    [SerializeField]
    public GameManager gameManager;

    public float moveSpeed;
    private Rigidbody2D rigidbody2D;
    public int Points;

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

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            gameManager.AddScore(Points);
            gameObject.SetActive(false);
        }
    }
}
