using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.VisualScripting.Member;
using UnityEngine.Networking;
using Newtonsoft.Json;
using UnityEngine.UI;
using System;
using JetBrains.Annotations;
using System.Reflection;

public class RequestManager : MonoBehaviour

{
    private string _apiBaseURL = "https://localhost:7100/api/ArchilandsControllers/GetLandmarkById/"; // change this to match your API URL

    public List<TMP_Text> landmarkTextButtons;
    /*public List<RawImage> landmarkImageButtons;
    public string imgNo;*/

    public void Start()
    {

    }

    public void GetLandmarkById(string id)
    {
        StartCoroutine(GetLandmarkId(id));
    }

    IEnumerator GetLandmarkId(string id)
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(_apiBaseURL + id))
        {
            yield return webRequest.SendWebRequest();

            switch (webRequest.result)
            {
                case UnityWebRequest.Result.DataProcessingError:
                    Debug.LogError(": Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.ProtocolError:
                    Debug.LogError(": HTTP Error: " + webRequest.error);
                    break;
                case UnityWebRequest.Result.Success:
                    Debug.Log(":\nReceived info from GetLandmarks: " + webRequest.downloadHandler.text);
                    Landmark _landmark = JsonConvert.DeserializeObject<Landmark>(webRequest.downloadHandler.text);

                   this.landmarkTextButtons[0].text = _landmark.land_head_1;
                   this.landmarkTextButtons[1].text = _landmark.land_text_1;
                   this.landmarkTextButtons[2].text = _landmark.land_head_2;
                   this.landmarkTextButtons[3].text = _landmark.land_text_2;
                   this.landmarkTextButtons[4].text = _landmark.land_head_3;
                   this.landmarkTextButtons[5].text = _landmark.land_text_3;
                   this.landmarkTextButtons[6].text = _landmark.land_head_4;
                   this.landmarkTextButtons[7].text = _landmark.land_text_4;
                    
              

                    break;
            }
        }
    }
    

}



