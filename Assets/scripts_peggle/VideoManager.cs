using System.Data.SqlTypes;
using System.Diagnostics;
using System.Security.AccessControl;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoManager : MonoBehaviour
{
    public RawImage image;
    private VideoPlayer videoPlayer;
    private VideoSource videoSource;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Application.runInBackground = true;
      //  StartCoroutine();
    }

    // Update is called once per frame
    void Update()
    {
        if (ScoreManager.Instance.score == 19840)
        {
            videoPlayer.Play();
        }
        else
        {
            videoPlayer.Stop();
        }
    }

}
