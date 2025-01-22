using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMove : MonoBehaviour
{
    private float inputVec;
    public float speed;
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.IsOver == true)
        {
            return;
        }
        
        inputVec = Input.GetAxis("Horizontal");
        if (inputVec > 0)
        {
            transform.Translate(new Vector3(0,0,1) * (speed * Time.deltaTime));
        }
        else if (inputVec < 0)
        {
            transform.Translate(new Vector3(0,0,-1) * (speed * Time.deltaTime));
        }
        else
        {
            
        }
    }
}
