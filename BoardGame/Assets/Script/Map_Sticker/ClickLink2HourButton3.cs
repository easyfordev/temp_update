using UnityEngine;
using System.Collections;

public class ClickLink2HourButton3 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=11672349&query=%EB%B9%84%ED%94%84%EA%B4%91%EC%9E%A5");
    }
}
