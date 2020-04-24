using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    public float ufoTL;
    private float ufoTimer;
    public bool off;

    public GameObject ufo;

    // Start is called before the first frame update
    void Start()
    {
        off = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!off)
        {
            ufoTL -= Time.deltaTime;
            ufoTimer = Mathf.Round(ufoTL);
            if (ufoTimer < 0)
            {
                off = true;
                ufo.SetActive(false);
                ufoTL = 3f;
            }
        }
        
    }
}
