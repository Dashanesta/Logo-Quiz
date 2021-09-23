using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class LogoLoader: MonoBehaviour
{
   // public static LogoLoader instance;
   // public void Awake() => instance = this;

    private void Start()
    {
        if (SceneChanger.level == 0)
        {
            McDonalds();
        }
        
        if (SceneChanger.level == 1)
        {
            Starbucks();
        }
    }

    public Image logo;
    public Sprite[] logos;
    
    public void McDonalds() // 0
    {
        logo.sprite = logos[0];
    }
    
    public void Starbucks() // 1
    {
        logo.sprite = logos[1];
    }
}
