﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLinkMapButton1 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/restaurants/detail?id=1963023227");
    }
}
