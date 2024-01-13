using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ActivatePanelAfterVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Drag & Drop the GameObject holding the VideoPlayer component
    public GameObject Panel;
    public GameObject PanelDeactivate;

    void Start()
    {
        videoPlayer.loopPointReached += LoadPanel;
    }

    public void LoadPanel(VideoPlayer vp)
    {
        Panel.gameObject.SetActive(true);
        PanelDeactivate.gameObject.SetActive(false);
    }
}
