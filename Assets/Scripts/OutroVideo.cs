using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class OutroVideo : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject Magazine;
    //private AudioSource audioSource;

    private void Awake()
    {
        videoPlayer = GameObject.Find("VideoPlayer").GetComponent<VideoPlayer>();
        Magazine = GameObject.Find("Magazine");
        Magazine.SetActive(false);

    }

    private void Update()
    {

        Invoke("EnableMagazine", 45);
        BackMainMenu();
    }


    public void EnableMagazine()
    {

        Magazine.SetActive(true);


    }


    public void BackMainMenu()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("Credits");

        }

    }


}
