using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
   public static int gas;

   float timer = 0;
   public static bool IsOver = false;
   public Canvas gameOverCanvas;

   private void Awake()
   {
       IsOver = false;
   }

   void Start()
    {
        gameOverCanvas.enabled = false;
        gas = 100;
    }

    void Update()
    {
        if (IsOver == true)
        {
            return;
        }
        
       timer += Time.deltaTime;
        if (timer >= 1f)
        {
            gas -= 10;
            timer = 0;
        }
        
        if (gas <= 0)
        {
            Debug.Log("Game Over");
            IsOver = true;
            gameOverCanvas.enabled = true;
        }
        
    }

    public void ResetGame()
    {
        SceneManager.LoadScene(0);
    }
    
}
