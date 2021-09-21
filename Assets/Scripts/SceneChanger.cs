using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
   // public static SceneChanger instance;
   // private void Awake() => instance = this;

   public static int levelName;

   public void Back()
   {
       SceneManager.LoadScene("LevelSelector");
   }
   
   public void McDonalds() // 0
   {
        SceneManager.LoadScene("LevelTemplate");
        levelName = 0;
   }
   
   public void Starbucks() // 1
   {
       SceneManager.LoadScene("LevelTemplate");
       levelName = 1;
   }
}
