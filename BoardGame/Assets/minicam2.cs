using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minicam2 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        WebCamDevice[] devices = WebCamTexture.devices;
        //for (int i = 0; i < devices.Length; i++)
        //Debug.Log(devices[i].name);

        WebCamTexture webcamTexture2 = new WebCamTexture(devices[0].name);
        Renderer renderer2 = GetComponent<Renderer>();
        renderer2.material.mainTexture = webcamTexture2;
        webcamTexture2.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
