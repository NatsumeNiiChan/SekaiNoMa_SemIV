using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class IntroManager : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    private GameObject introScreen;
    private AudioSource audioSource;

    private void Awake()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        introScreen = GameObject.Find("Intro");
        audioSource = FindObjectOfType<AudioSource>();

        audioSource.mute = true;
    }

    private void Update()
    {
        if (videoPlayer.isPlaying == false)
        {
            introScreen.SetActive(false);
            audioSource.mute = false;
        }
    }
}
