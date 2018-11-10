using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ClickLinkFoodButton4 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://store.naver.com/restaurants/detail?id=13572738&tab=photo&photoIndex=0#_tab");
    }
}
