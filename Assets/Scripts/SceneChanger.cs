using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChanger : MonoBehaviour
{
   public static SceneChanger instance;
   private void Awake() => instance = this;

   public static int level;

   private void LoadLevel()
   {
       if (Controller.instance.data.levelsCompleted[level - 1])
       {
           SceneManager.LoadScene("LevelTemplate");
       }
   }
   
   public void Back()
   {
       SceneManager.LoadScene("LevelSelector");
   }
   
   public void Level1()
   {
       level = 0;
       SceneManager.LoadScene("LevelTemplate");
   }
   
   public void Level2()
   {
       level = 1;
       LoadLevel();
   }
   
   public void Level3()
   {
       level = 2;
       LoadLevel();
   }
   
   public void Level4()
   {
       level = 3;
       LoadLevel();
   }
   
   public void Level5()
   {
       level = 4;
       LoadLevel();
   }
   
   public void Level6()
   {
       level = 5;
       LoadLevel();
   }
   
   public void Level7()
   {
       level = 6;
       LoadLevel();
   }
   
   public void Level8()
   {
       level = 7;
       LoadLevel();
   }
   
   public void Level9()
   {
       level = 8;
       LoadLevel();
   }
   
   public void Level10()
   {
       level = 9;
       LoadLevel();
   }
   
   public void Level11()
   {
       level = 10;
       LoadLevel();
   }
   
   public void Level12()
   {
       level = 11;
       LoadLevel();
   }
   
   public void Level13()
   {
       level = 12;
       LoadLevel();
   }
   
   public void Level14()
   {
       level = 13;
       LoadLevel();
   }
}
