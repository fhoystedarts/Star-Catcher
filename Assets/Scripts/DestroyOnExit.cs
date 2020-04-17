using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnExit : MonoBehaviour
{
    public void Destroy()
    {
        Destroy(gameObject); 
    }
}
