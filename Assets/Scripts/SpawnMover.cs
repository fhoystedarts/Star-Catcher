using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMover : MonoBehaviour
{
    private float halfSpawnerHeight;
    public float speed;
    private Vector2 screenSize;
    public GameObject spawnArea;

    public bool moveUp;
    public bool moveDown;

    // Start is called before the first frame update
    void Start()
    {
        halfSpawnerHeight = transform.localScale.y / 2;
        screenSize = (spawnArea.GetComponent<Collider2D>().bounds.size/2);
    }

    // Update is called once per frame
    void Update()
    {
        MoveUpandDown();
    }

    void MoveUpandDown()
    {
        if (transform.position.y < - screenSize.y)
        {
            moveDown = false;
            moveUp = true;
        }
        else if (transform.position.y > screenSize.y)
        {
            moveUp = false;
            moveDown = true;
        }

        if(moveUp)
        {
            transform.Translate(Vector3.up * (speed * Time.deltaTime));
        }
        else if(moveDown)
        {
            transform.Translate(Vector3.down * (speed * Time.deltaTime));
        }
    }
}
