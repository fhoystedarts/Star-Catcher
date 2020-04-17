using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    

    public float moveSpeed;
    private Rigidbody2D rigidbody2D;
    private Animator animator;
    public bool collected;
    
   

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        collected = false;

    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2D.velocity = new Vector3(-moveSpeed, rigidbody2D.velocity.y, 0f);
        animator.SetBool("Collected", collected);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") || collision.gameObject.CompareTag("UFO"))
        {
            collected = true;
        }
    }

    public void Reset()
    {
        gameObject.SetActive(false);
        collected = false;
    }
}
