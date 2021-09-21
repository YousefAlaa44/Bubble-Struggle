using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    public Vector2 StartForce;
    public Rigidbody2D rb;
    public GameObject NextBall;

    void Start()
    {
        rb.AddForce(StartForce, ForceMode2D.Impulse);
    }

    public void Split()
    {
        if (NextBall != null)
        {
            GameObject Ball1 = Instantiate(NextBall, rb.position + Vector2.right / 4, Quaternion.identity);
            GameObject Ball2 = Instantiate(NextBall, rb.position + Vector2.left / 4, Quaternion.identity);

            Ball1.GetComponent<Ball>().StartForce = new Vector2(2f, 5f);
            Ball2.GetComponent<Ball>().StartForce = new Vector2(-2f, 5f);
        }
        Destroy(gameObject);
        
    }

   
    
}
