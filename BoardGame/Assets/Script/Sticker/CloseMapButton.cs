using UnityEngine;
using System.Collections;

public class CloseMapButton : MonoBehaviour
{
    public GameObject Map1;
    public GameObject Map2;
    public GameObject Map3;
    public GameObject CloseButton;
    public GameObject Route1;
    public GameObject Route2;
    public GameObject Route3;
    public GameObject Route1Button;
    public GameObject Route2Button;
    public GameObject Route3Button;
    public GameObject icon1;
    public GameObject icon2;
    public GameObject icon3;
    public GameObject basic;
    // Use this for initialization

    // Update is called once per frame
    public void Click()
    {
        Map1.SetActive(false);
        Map2.SetActive(false);
        Map3.SetActive(false);
        CloseButton.SetActive(false);
        basic.SetActive(false);
        icon1.SetActive(false);
        icon2.SetActive(false);
        icon3.SetActive(false);
        Route1.SetActive(true);
        Route2.SetActive(true);
        Route3.SetActive(true);
        Route1Button.SetActive(true);
        Route2Button.SetActive(true);
        Route3Button.SetActive(true);
    }
}
