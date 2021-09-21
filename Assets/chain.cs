using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chain : MonoBehaviour
{
    public static bool IsFired;
    public Transform player;
    public float ChainSpeed = 2f;
    void Start()
    {
        IsFired = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
           IsFired = true;
        }
        if (IsFired)
        {
            transform.localScale = transform.localScale + Vector3.up * Time.deltaTime * ChainSpeed;
        }
        else
        {
            transform.position = player.position;
            transform.localScale = new Vector3(1f, 0f, 1f);
        }
    }
}
