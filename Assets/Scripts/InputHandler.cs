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

    public void OnInput()
    {
        input = inputField.text;
        if (String.Compare(input, logoName, true, CultureInfo.CurrentCulture) == 0)
        {
            print("yay");
        }
        else
        {
            print(input);
        }
    }
}