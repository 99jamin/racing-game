using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasGen : MonoBehaviour
{
    public GameObject gas;
    
    private float timer;
    private float genTime = 1f;
    private int genPos;
    void Start()
    {
        
    }

    void Update()
    {
        if (GameManager.IsOver == true)
        {
            return;
        }
        
        timer += Time.deltaTime;
        
        if (timer >= genTime)
        {
            timer = 0;
            genTime = Random.Range(0.8f, 1.5f);
            genPos = Random.Range(-1, 1);
            
            Instantiate(gas, new Vector3(genPos * 7,1,20), transform.rotation);
            
        }
        
    }
}
