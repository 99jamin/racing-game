using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GasUI : MonoBehaviour
{
    TextMeshProUGUI text;
    
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = "Gas : " + GameManager.gas.ToString();
    }
}
