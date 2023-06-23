using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoEnd : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private GameObject introScreen;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        introScreen = GameObject.Find("Intro");
    }

    private void Update()
    {
        if (videoPlayer.isPlaying == false)
        {
            introScreen.SetActive(false);
        }
    }
}
