using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static Unity.VisualScripting.Member;
using UnityEngine.Networking;
using Newtonsoft.Json;

public class RequestManager : MonoBehaviour

{
    private string _apiBaseURL = "https://localhost:7224/api/"; // change this to match your API URL

    public List<TMP_Text> courseTextButtons;

    public void Start()
    {

    }

    public void GetAllCourses()
    {
        StartCoroutine(GetCourses());
    }

    IEnumerator GetCourses()
    {
        using (UnityWebRequest webRequest = UnityWebRequest.Get(_apiBaseURL + "University/GetCourses"))
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
                //case UnityWebRequest.Result.Success:
                   // Debug.Log(":\nReceived info from GetCouses: " + webRequest.downloadHandler.text);

                   // CourseList _courses = JsonConvert.DeserializeObject<CourseList>("{\"courses\":" + webRequest.downloadHandler.text + "}");
                    //Debug.Log(_courses.courses.Count);

                    //foreach (Course c in _courses.courses)
                    {
                       // Debug.Log("Couse ID -> " + c.cour_id + " | Course Name -> " + c.cour_name);
                    }
                    //break;
            }
        }
    }

    public void GetCourseById(string id)
    {
        StartCoroutine(GetCourseId(id));
    }

    IEnumerator GetCourseId(string id)
    {
        Debug.Log("Working");
        using (UnityWebRequest webRequest = UnityWebRequest.Get(_apiBaseURL + "University/GetCourseById/" + id))
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
                    Debug.Log(":\nReceived info from GetCouses: " + webRequest.downloadHandler.text);
                    //Course _course = JsonConvert.DeserializeObject<Course>(webRequest.downloadHandler.text);

                   // this.courseTextButtons[0].text = "" + _course.cour_id;
                    //this.courseTextButtons[1].text = _course.cour_name;
                    break;
            }
        }
    }
}



