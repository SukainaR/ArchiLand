using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;


/*public class ImageDisplay : MonoBehaviour
{
    public List<RawImage> landmarkImageButtons;
    public string imgNo;
    int index = int.Parse(imgNo);
    UnityWebRequest www;

                    if (index == 0)
                    {
                        www = UnityWebRequestTexture.GetTexture(_landmark.land_img_1);
                    }
                    else if (index == 1)
{
    www = UnityWebRequestTexture.GetTexture(_landmark.land_img_2);
}
else if (index == 2)
{
    www = UnityWebRequestTexture.GetTexture(_landmark.land_img_3);
}
else
{
    www = null;
    Debug.Log("No Value");
}

yield return www.SendWebRequest();
if (www.result != UnityWebRequest.Result.Success)
{
    Debug.Log(www.error);
}
else
{
    Texture myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
    landmarkImageButtons[index].texture = myTexture;
}*/
