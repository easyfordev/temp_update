using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLinkFoodButton5 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/restaurants/detail?id=32762455&query=%EC%9D%B4%EA%B0%80%EB%84%A4%EB%96%A1%EB%B3%B6%EC%9D%B4");
    }
}
