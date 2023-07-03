using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class OutroVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    private GameObject introScreen;
    //private AudioSource audioSource;

    private void Awake()
    {
        videoPlayer = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();

    }

    private void Update()
    {
        Invoke("LoadCredits", 52);


    }




    public void LoadCredits()
    {
        SceneManager.LoadScene("Credits");

    }

}
