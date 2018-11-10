using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLinkFoodButton2 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/restaurants/detail?id=13485911&query=%EB%B3%B8%EC%A0%84%EB%8F%BC%EC%A7%80%EA%B5%AD%EB%B0%A5");
    }
}
