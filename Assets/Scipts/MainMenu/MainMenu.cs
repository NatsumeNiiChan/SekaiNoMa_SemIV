using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Buttons
    private GameObject B_StartGame;
    private GameObject B_EndGame;
    private GameObject B_LoadGame;
    private GameObject B_Settings;
    private GameObject B_Diary;


//START
    void Start()
    {
        FindingCall_Buttons();




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

    public void FindingCall_Buttons()
    {
        B_StartGame = GameObject.Find("Start_Game");
        B_LoadGame = GameObject.Find("Load_Game");
        B_Diary = GameObject.Find("Diary");
        B_Settings = GameObject.Find("Settings");
        B_EndGame = GameObject.Find("Quit_Game");

    }



}
