using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapMove : MonoBehaviour
{
    public float speed = 5f;
    
    void Start()
    {
        //z값이 -10이 되면 50으로 이동
    }

    void Update()
    {
        transform.Translate(Vector3.back * (speed * Time.deltaTime));

        if (transform.position.z < -70)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 50);
        }
    }
}
