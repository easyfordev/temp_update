using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLinkFoodButton1 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/restaurants/detail?id=11833745&query=%EC%8B%A0%EB%B0%9C%EC%9B%90");
    }
}
