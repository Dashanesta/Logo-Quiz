using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class InputHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    private string input;
    public TMP_Text correctText;
    public Image logo;
    private string logoName;

    private void Start()
    {
        logoName = logo.sprite.name;
    }

    public void OnInput()
    {
        input = inputField.text;
        if (String.Compare(input, logoName, true, CultureInfo.CurrentCulture) == 0)
        {
            correctText.text = "Correct!";
            correctText.color = Color.green;
        }
        else
        {
            correctText.text = "Incorrect!";
            correctText.color = Color.red;
        }
    }
}