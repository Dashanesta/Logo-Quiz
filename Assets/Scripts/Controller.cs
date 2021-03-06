using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    public static Controller instance;
    private void Awake() => instance = this;
    
    public Data data;
    
    public const string dataFileName = "PlayerData";

    public TMP_Text starText;
    
    private void Start()
    {
            data = SaveSystem.SaveExists(dataFileName)
            ? SaveSystem.LoadData<Data>(dataFileName)
            : new Data();
            
            IconHandler.instance.LoadStars();
            IconHandler.instance.SetLockIcons();
            instance.SetStarText();
            
    }

    public void SetStarText()
    {
        if (starText != null)
        {
            instance.starText.text = instance.data.stars.ToString();
        }
    }

    private void OnDestroy()
    {
        SaveTimer.SaveGame();
    }
}
