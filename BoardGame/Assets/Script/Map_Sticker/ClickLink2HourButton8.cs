using UnityEngine;
using System.Collections;

public class ClickLink2HourButton8 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=17004424&query=%EB%8F%99%EB%B0%B1%EA%B3%B5%EC%9B%90");
    }
}
