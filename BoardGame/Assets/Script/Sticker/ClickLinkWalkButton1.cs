using UnityEngine;
using System.Collections;

public class ClickLinkWalkButton1 : MonoBehaviour
{
    public GameObject place;
    public GameObject button;

    public void Click()
    {
        //Text P_path = button.GetComponent<Text>();
        Application.OpenURL("https://m.post.naver.com/viewer/postView.nhn?volumeNo=337308&memberNo=839&vType=VERTICAL");
    }
}
