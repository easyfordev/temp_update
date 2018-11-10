using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public struct Screen
{
    [Range(0, 1920)]
    public int width;

    [Range(0, 1080)]
    public int height;
}

public class WebCam : MonoBehaviour
{
    [SerializeField]
    private Screen screen;

    [SerializeField]
    [Range(0, 90)]
    private int fps = 60;

    [SerializeField]
    private Image projectionImage;

    private WebCamTexture webcam;

    private void Awake()
    {
        //webcam = new WebCamTexture(screen.width, screen.height, fps);

        //webcam.Play();

        //projectionImage.material.mainTexture = webcam;

        WebCamDevice[] devices = WebCamTexture.devices;
        webcam = new WebCamTexture(devices[0].name, screen.width, screen.height, fps);

        webcam.Play();

        Debug.Log(devices[0].name);
        projectionImage.material.mainTexture = webcam;
    }
}
