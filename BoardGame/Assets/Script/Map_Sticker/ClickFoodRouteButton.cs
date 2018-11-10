using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickFoodRouteButton : MonoBehaviour {
    //public GameObject RouteButton;
    public GameObject Map1;
    public GameObject Map2;
    public GameObject Map3;
    public GameObject Map4;
    public GameObject Map5;
    public GameObject Map1Button;
    public GameObject Map2Button;
    public GameObject Map3Button;
    public GameObject Map4Button;
    public GameObject Map5Button;
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

        Background.SetActive(true);
        CloseButton.SetActive(true);

        /*basic.SetActive(true);

        icon1.SetActive(true);
        icon2.SetActive(true);
        icon3.SetActive(true);*/

        //Route1.SetActive(false);
        //Route1Button.SetActive(false);
        Route2.SetActive(false);
        //Route2Button.SetActive(false);
        Route3.SetActive(false);
        //Route3Button.SetActive(false);
    }
}
