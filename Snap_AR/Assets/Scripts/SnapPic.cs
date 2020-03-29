using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class SnapPic : MonoBehaviour {
    public int num = 1;
    public int picNum = 0;

   public void TakePicAndDownload()
    {
        picNum += num;
        print(picNum);
        ScreenCapture.CaptureScreenshot(Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments),"screenshot" + picNum.ToString() + ".png"));
    }



   
}
