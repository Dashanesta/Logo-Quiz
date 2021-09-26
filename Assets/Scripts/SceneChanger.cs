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
   
   public void Level15()
   {
       level = 14;
       LoadLevel();
   }
   
   public void Level16()
   {
       level = 15;
       LoadLevel();
   }
   
   public void Level17()
   {
       level = 16;
       LoadLevel();
   }
   
   public void Level18()
   {
       level = 17;
       LoadLevel();
   }
   
   public void Level19()
   {
       level = 18;
       LoadLevel();
   }
   
   public void Level20()
   {
       level = 19;
       LoadLevel();
   }
   
   public void Level21()
   {
       level = 20;
       LoadLevel();
   }
   
   public void Level22()
   {
       level = 21;
       LoadLevel();
   }
   
   public void Level23()
   {
       level = 22;
       LoadLevel();
   }
   
   public void Level24()
   {
       level = 23;
       LoadLevel();
   }
   
   public void Level25()
   {
       level = 24;
       LoadLevel();
   }
   
   public void Level26()
   {
       level = 25;
       LoadLevel();
   }
   
   public void Level27()
   {
       level = 26;
       LoadLevel();
   }
   
   public void Level28()
   {
       level = 27;
       LoadLevel();
   }
   
   public void Level29()
   {
       level = 28;
       LoadLevel();
   }
   
   public void Level30()
   {
       level = 29;
       LoadLevel();
   }
   
   public void Level31()
   {
       level = 30;
       LoadLevel();
   }
   
   public void Level32()
   {
       level = 31;
       LoadLevel();
   }
   
   public void Level33()
   {
       level = 32;
       LoadLevel();
   }
   
   public void Level34()
   {
       level = 33;
       LoadLevel();
   }
   
   public void Level35()
   {
       level = 34;
       LoadLevel();
   }
   
   public void Level36()
   {
       level = 35;
       LoadLevel();
   }
   
   public void Level37()
   {
       level = 36;
       LoadLevel();
   }
   
   public void Level38()
   {
       level = 37;
       LoadLevel();
   }
   
}
