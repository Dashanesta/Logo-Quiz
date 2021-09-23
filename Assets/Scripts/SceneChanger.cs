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
       Controller.instance.starText.text = Controller.instance.data.stars.ToString();
   }
   
   public void McDonalds() // 0
   {
        SceneManager.LoadScene("LevelTemplate");
        level = 0;
   }
   
   public void Starbucks() // 1
   {
       SceneManager.LoadScene("LevelTemplate");
       level = 1;
   }
}
