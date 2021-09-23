using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Data
{
    public int stars;
    public bool[] levelsCompleted = new bool[1000];

    public Data()
    {
        stars = 0;
    }

}

