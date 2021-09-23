using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconHandler : MonoBehaviour
{
    public static IconHandler instance;
    private void Awake() => instance = this;

    public GameObject[] logoButtons = new GameObject[1000];

    public void LoadStars()
    {
        var data = Controller.instance.data;
        for (int i = 0; i < data.levelsCompleted.Length; i++)
        {
            if (data.levelsCompleted[i])
            {
                if (logoButtons[i] != null)
                {
                    logoButtons[i].transform.GetChild(1).gameObject.SetActive(true);
                }
            }
        }
    }

    public void SetLockIcons()
    {
        var data = Controller.instance.data;
        for (int i = 0; i < data.levelsCompleted.Length; i++)
        {
            if (data.levelsCompleted[i] == false && logoButtons[i] != null)
            {
                if (logoButtons[i + 1] != null)
                {
                        logoButtons[i + 1].transform.GetChild(2).gameObject
                        .SetActive(true);
                }
            }
        }
    }
}