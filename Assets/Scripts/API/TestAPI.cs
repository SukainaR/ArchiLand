using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class TestAPI : MonoBehaviour
{
    private const string URL = "https://localhost:7100/api/ArchilandsControllers/GetLandmarkById/2";
    public void GenerateRequest()
    {
        StartCoroutine(ProcessRequest(URL));
    }
    private IEnumerator ProcessRequest(string uri)
    {
        using (UnityWebRequest request = UnityWebRequest.Get(uri))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.Log(request.error);
            }
            else
            {
                Debug.Log(request.downloadHandler.text);
            }
        }
    }
}


