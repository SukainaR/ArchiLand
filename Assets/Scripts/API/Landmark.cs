using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

[SerializeField]
public class Landmark 
{
    public int land_id { get; set; }
    public string land_name { get; set; }
    public string land_head_1 { get; set; }
    public string land_text_1 { get; set; }
    public string land_head_2 { get; set; }
    public string land_text_2 { get; set; }
    public string land_head_3 { get; set; }
    public string land_text_3 { get; set; }
    public string land_head_4 { get; set; }
    public string land_text_4 { get; set; }
    public string land_img_1 { get; set; }
    public string land_img_2 { get; set; }
    public string land_img_3 { get; set; }
    public int land_map_id { get; set; }

    public IEnumerator SetImageTexture(int index, RawImage imgGameObject)
    {
        UnityWebRequest www;

        if (index == 1)
        {
            www = UnityWebRequestTexture.GetTexture(land_img_1);
        } else if (index == 2)
        {
            www = UnityWebRequestTexture.GetTexture(land_img_2);
        }
        else
        {
            www = UnityWebRequestTexture.GetTexture(land_img_3);
        }

        yield return www.SendWebRequest();
        if (www.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(www.error);
        }
        else
        {
            Texture myTexture = ((DownloadHandlerTexture)www.downloadHandler).texture;
            imgGameObject.texture = myTexture;
        }
    }
}
