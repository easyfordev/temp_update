using UnityEngine;
using System.Collections;

public class ClickLink2HourButton7 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=12848261&query=%EB%B3%B4%EC%88%98%EB%8F%99%EC%B1%85%EB%B0%A9%EA%B3%A8%EB%AA%A9");
    }
}
