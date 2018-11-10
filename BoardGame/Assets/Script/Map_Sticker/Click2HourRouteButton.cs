using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Click2HourRouteButton : MonoBehaviour {
    //public GameObject RouteButton;
    public GameObject Map1;
    public GameObject Map2;
    public GameObject Map3;
    public GameObject Map4;
    public GameObject Map5;
    public GameObject Map6;
    public GameObject Map7;
    public GameObject Map8;
    public GameObject Map9;
    public GameObject Map10;
    public GameObject Map1Button;
    public GameObject Map2Button;
    public GameObject Map3Button;
    public GameObject Map4Button;
    public GameObject Map5Button;
    public GameObject Map6Button;
    public GameObject Map7Button;
    public GameObject Map8Button;
    public GameObject Map9Button;
    public GameObject Map10Button;
    public GameObject CloseButton;
    public GameObject Route1;
    public GameObject Route2;
    public GameObject Route3;
    public GameObject Route1Button;
    public GameObject Route2Button;
    public GameObject Route3Button;
    public GameObject Background;
    /*public GameObject icon1;
    public GameObject icon2;
    public GameObject icon3;
    public GameObject basic;*/

    public void Click()
    {
        Map1.SetActive(true);
        Map1Button.SetActive(true);
        Map2.SetActive(true);
        Map2Button.SetActive(true);
        Map3.SetActive(true);
        Map3Button.SetActive(true);
        Map4.SetActive(true);
        Map4Button.SetActive(true);
        Map5.SetActive(true);
        Map5Button.SetActive(true);
        Map6.SetActive(true);
        Map6Button.SetActive(true);
        Map7.SetActive(true);
        Map7Button.SetActive(true);
        Map8.SetActive(true);
        Map8Button.SetActive(true);
        Map9.SetActive(true);
        Map9Button.SetActive(true);
        Map10.SetActive(true);
        Map10Button.SetActive(true);

        Background.SetActive(true);
        CloseButton.SetActive(true);

        /*basic.SetActive(true);

        icon1.SetActive(true);
        icon2.SetActive(true);
        icon3.SetActive(true);*/

        Route1.SetActive(false);
        //Route1Button.SetActive(false);
        Route2.SetActive(false);
        //Route2Button.SetActive(false);
        //Route3.SetActive(false);
        //Route3Button.SetActive(false);
    }
}
