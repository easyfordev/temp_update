using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLinkFoodButton3 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/restaurants/detail?id=16433174&query=%EC%9D%B4%EC%9E%AC%EB%AA%A8%ED%94%BC%EC%9E%90");
    }
}
