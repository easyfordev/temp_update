using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLinkMapButton3 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/restaurants/detail?id=509205075&query=TEJE");
    }
}
