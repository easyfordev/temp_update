using UnityEngine;
using System.Collections;

public class ClickLink2HourButton1 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=11622430&query=%EC%9A%A9%EB%91%90%EC%82%B0%EA%B3%B5%EC%9B%90");
    }
}
