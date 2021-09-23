using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public static InputHandler instance;
    private void Awake() => instance = this;
    
    public TMP_InputField inputField;
    private string input;
    public TMP_Text correctText;
    public Image logo;
    private string logoName;

    private void Start()
    {
        var data = Controller.instance.data;
        data.stars = Stars();
        logoName = logo.sprite.name;
    }

    private int levelsCompletedInt = 0;
    
    private int Stars()
    {
        var data = Controller.instance.data;
        levelsCompletedInt = 0;
        for(int i = 0; i < data.levelsCompleted.Length; i++)
        {
            if (data.levelsCompleted[i])
            {
                levelsCompletedInt++;
            }
        }
        
        return levelsCompletedInt;
    }
    
    public void OnInput()
    {
        var data = Controller.instance.data;
        input = inputField.text;
        if (String.Compare(input, logoName, true, CultureInfo.CurrentCulture) == 0)
        {
            correctText.text = "Correct!";
            correctText.color = Color.green;
            data.levelsCompleted[SceneChanger.level] = true;
            Stars();
            data.stars = Stars();
        }
        else
        {
            correctText.text = "Incorrect!";
            correctText.color = Color.red;
        }
    }
}