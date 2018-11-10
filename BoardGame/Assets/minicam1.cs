using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minicam1 : MonoBehaviour {

	// Use this for initialization
	void Start () {

        WebCamDevice[] devices = WebCamTexture.devices;
        //for (int i = 0; i < devices.Length; i++)
            //Debug.Log(devices[i].name);

        WebCamTexture webcamTexture1 = new WebCamTexture(devices[1].name);
        Renderer renderer1 = GetComponent<Renderer>();
        renderer1.material.mainTexture = webcamTexture1;
        webcamTexture1.Play();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
