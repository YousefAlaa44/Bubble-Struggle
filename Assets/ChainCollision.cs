using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChainCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D col)
    {
        chain.IsFired = false;

        if (col.tag == "Ball")
        {           
            col.GetComponent<Ball>().Split();
        }
        
    }
}
