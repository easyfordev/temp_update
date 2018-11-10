using UnityEngine;
using System.Collections;

public class ClickLink2HourButton5 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/attractions/detail?entry=plt&id=21884707&query=%EA%B0%90%EC%B2%9C%EB%AC%B8%ED%99%94%EB%A7%88%EC%9D%84");
    }
}
