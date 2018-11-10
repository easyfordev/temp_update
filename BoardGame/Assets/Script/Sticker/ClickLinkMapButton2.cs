using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLinkMapButton2 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/restaurants/detail?entry=plt&id=13359769&query=%EA%B5%AD%EC%A0%9C%EB%B0%80%EB%A9%B4");
    }
}
