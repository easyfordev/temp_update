using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardConvert2 : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        //print("kkkk");
        Renderer rend = GetComponent<Renderer>();

        rend.material.SetColor("_Color", Color.blue);
    }

    // Update is called once per frame  
    void Update()
    {

    }

    private void OnMouseDown()
    {
        Renderer rend = GetComponent<Renderer>();

        if (rend.material.GetColor("_Color") == Color.blue)
        {
            rend.material.SetColor("_Color", Color.red);
        }
        else if (rend.material.GetColor("_Color") == Color.red)
        {
            rend.material.SetColor("_Color", Color.blue);
        }
    }
}
