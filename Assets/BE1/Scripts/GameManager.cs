using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    
   public static bool isLive;
   public static bool isFinish = false;
   public static bool isHit = false;
   public static int score;
   public static int health = 3;
   public static int level = 0;

   public static Material skin;
   public static BGMManager bgm;

   private void Awake()
   {
       if (!PlayerPrefs.HasKey("Score"))
       {
           PlayerPrefs.SetInt("Score", 0);
       }

       bgm = FindObjectOfType<BGMManager>();
   }

   // Start is called before the first frame update
    void Start()
    {
        
        isFinish = false;
        isHit = false;
        Debug.Log(isFinish);
    }

    public static void GetItem()
    {
        score += 100;
    }

    public static void GameStart()
    {
        isLive = true;
        Next();
    }

    public static void GameOver()
    {
        Destroy(bgm.gameObject);
        SceneManager.LoadScene("End");
    }

    public static void Next()
    {
        
        level += 1;
        score += ((level > 1) ? 1000 : 0);

        if (level < 4)
        {
            SceneManager.LoadScene("Game");
        }
        else
        {
            int highScore = PlayerPrefs.GetInt("Score");
            PlayerPrefs.SetInt("Score", Mathf.Max(highScore,score));
            GameOver();

        }
        isFinish = true;
    }

    public static void DataClear()
    {
        isLive = false;
        isFinish = false;
        isHit = false;
        score = 0;
        health = 3;
        level = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
