using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class LogoLoader : MonoBehaviour
{
    public Image logo;
    public Sprite[] logos;

    private void Start()
    {
        if (logo != null)
        {
            logo.sprite = logos[SceneChanger.level];
        }
    }
}