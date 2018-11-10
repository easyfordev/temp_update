using UnityEngine;
using System.Collections;

public class ClickLinkWalkButton3 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://map.naver.com/local/siteview.nhn?code=36414428&_ts=1538292683238");
    }
}
