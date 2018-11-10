using UnityEngine;
using System.Collections;

public class ClickLinkWalkButton2 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=16855498&query=%EC%9D%B4%EA%B8%B0%EB%8C%80%ED%95%B4%EC%95%88%EC%82%B0%EC%B1%85%EB%A1%9C");
    }
}
