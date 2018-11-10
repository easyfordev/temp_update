using UnityEngine;
using System.Collections;

public class ClickLink2HourButton9 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=12104874&query=%EB%B6%80%EC%82%B0%EB%AF%BC%EC%A3%BC%EA%B3%B5%EC%9B%90");
    }
}
