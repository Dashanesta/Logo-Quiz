using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using TMPro;

public class InputHandler : MonoBehaviour
{
    public TMP_InputField inputField;
    private string input;
    public string logoName;
    public TMP_Text correctText;

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