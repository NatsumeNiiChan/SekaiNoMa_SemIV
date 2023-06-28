using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    //[HideInInspector] 
    public SceneManagement S_SceneManagement;

    //Buttons
    //private GameObject B_StartGame;
    //private GameObject B_EndGame;
    //private GameObject B_LoadGame;
    //private GameObject B_Settings;
    //private GameObject B_Diary;


//START
    void Start()
    {
        S_SceneManagement = GameObject.Find("GameManager").GetComponent<SceneManagement>();

        //FindingCall_Buttons();

        S_SceneManagement._SceneIndex = 0 ;


    }

    //UPDATE
    void Update()
    {
        
    }

//FUNCTIONS

    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");

    }

    public void ExitGame()
    {
        Application.Quit();

    }

    public void Diary()
    {
        SceneManager.LoadScene("DiaryScene");

    }

    public void Settings()
    {
        //zukünftiges enable settings UI

    }



//FINDING CALLS

    /*public void FindingCall_Buttons()
    {
        B_StartGame = GameObject.Find("Start_Game");
        B_LoadGame = GameObject.Find("Load_Game");
        B_Diary = GameObject.Find("Diary");
        B_Settings = GameObject.Find("Settings");
        B_EndGame = GameObject.Find("Quit_Game");

    }*/



}
