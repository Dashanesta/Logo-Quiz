using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   public static SceneChanger instance;
   private void Awake() => instance = this;

   public static int level;

   public void Back()
   {
       SceneManager.LoadScene("LevelSelector");
   }
   
   public void McDonalds() // 0
   {
       level = 0;
       SceneManager.LoadScene("LevelTemplate");
   }
   
   public void Starbucks() // 1
   {
       level = 1;
       if (Controller.instance.data.levelsCompleted[level - 1])
       {
           SceneManager.LoadScene("LevelTemplate");
       }

   }
}
