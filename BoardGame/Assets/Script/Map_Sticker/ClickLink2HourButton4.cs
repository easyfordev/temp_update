using UnityEngine;
using System.Collections;

public class ClickLink2HourButton4 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=11535750&query=%EB%B6%80%EC%82%B0%EC%9E%90%EA%B0%88%EC%B9%98%EC%8B%9C%EC%9E%A5");
    }
}
