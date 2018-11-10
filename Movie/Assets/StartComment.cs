using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartComment : MonoBehaviour {

    public string comment1 = "Hahaha";
    public string comment2 = "Great";
    public string comment3 = "Excelent!";

    public Text text1, text2, text3;
    public Button btn1, btn2, btn3;

	// Use this for initialization

    void setText1(){
        var colors = btn1.colors;
        colors.normalColor = Color.white;
        btn1.colors = colors;
        text1.text = comment1;
    }

    void setText2()
    {
        var colors = btn2.colors;
        colors.normalColor = Color.white;
        btn2.colors = colors;
        text2.text = comment2;
    }

    void setText3()
    {
        var colors = btn3.colors;
        colors.normalColor = Color.white;
        btn3.colors = colors;
        text3.text = comment3;
    }

    // Update is called once per frame
    void Update () {

        Invoke("setText1", 1);
        Invoke("setText2", 9);
        Invoke("setText3", 16);

        //Invoke("outText", 3);
        ////CancelInvoke("setText");

        //Invoke("setText", 1);


    }
}