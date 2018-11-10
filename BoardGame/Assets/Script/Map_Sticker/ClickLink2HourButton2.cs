using UnityEngine;
using System.Collections;

public class ClickLink2HourButton2 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=13491723&query=%EA%B5%AD%EC%A0%9C%EC%8B%9C%EC%9E%A5");
    }
}
