using UnityEngine;
using System.Collections;

public class ClickLink2HourButton10 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?id=36667484&query=%EC%B2%AD%ED%95%99%EB%B0%B0%EC%88%98%EC%A7%80%EC%A0%84%EB%A7%9D%EB%8C%80");
    }
}
