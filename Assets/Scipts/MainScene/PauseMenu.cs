using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    [HideInInspector] public SceneManagement S_SceneManagement;


    private GameObject _PauseMenu;




//START
    void Start()
    {
        S_SceneManagement = GameObject.Find("GameManager").GetComponent<SceneManagement>();


        _PauseMenu = GameObject.Find("PauseScreen");
        _PauseMenu.SetActive(false);


        S_SceneManagement._SceneIndex = 1;
        Debug.Log(S_SceneManagement._SceneIndex);

    }

    //UPDATE
    void Update()
    {
        OpenPauseMenu();

    }


    //Diary
    public void Diary()
    {
        SceneManager.LoadScene("DiaryScene");

    }


    //OPenPauseMenu

    public void OpenPauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            _PauseMenu.SetActive(true);

        }


    }

    //Back to Game
    public void BackToGame()
    {
        _PauseMenu.SetActive(false);

    }

    //Settings





    //Quit Game
    public void MainMenu()
    {
        //Application.Quit();
        SceneManager.LoadScene("GameMenu");
    }
}
