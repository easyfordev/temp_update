using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShot : MonoBehaviour
{
    private const string dateFormat = "yyyy-MM-dd-HH-mm-ss";

    //private const string directory = "ScreenShot//";

    private const string saveType = ".png";

    public void Capture()
    {
        string date = System.DateTime.Now.ToString(dateFormat);

        Debug.Log(string.Format(date, saveType));

        if (Application.isEditor)
            ScreenCapture.CaptureScreenshot(date + saveType);


        else
            ScreenCapture.CaptureScreenshot("..//" + date + saveType);
    }
}
