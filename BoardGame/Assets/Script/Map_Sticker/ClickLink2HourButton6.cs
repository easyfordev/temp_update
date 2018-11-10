using UnityEngine;
using System.Collections;

public class ClickLink2HourButton6 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=12079965&query=%ED%83%9C%EC%A2%85%EB%8C%80");
    }
}
