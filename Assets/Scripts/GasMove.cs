using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasMove : MonoBehaviour
{
    public float speed = 5f;
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.IsOver == true)
        {
            return;
        }
        
        transform.Translate(Vector3.back * (Time.deltaTime * speed));
        if (transform.position.z < -50)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameManager.gas += 10;
        Destroy(gameObject);
    }
}
