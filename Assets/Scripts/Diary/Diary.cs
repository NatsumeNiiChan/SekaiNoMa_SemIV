using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diary : MonoBehaviour
{
    //Scripts
    [HideInInspector] public SceneManagement S_SceneManagement;

    //DiaryPages
    public GameObject[] A_DiaryPages = new GameObject[17];

    //Counter
    private int _PageCounter = 0;

    private int DNewGameInt;
    private GameObject ToNewButton;

//START
    void Awake()
    {
        S_SceneManagement = GameObject.Find("GameManager").GetComponent<SceneManagement>();
        ToNewButton = GameObject.Find("B_GoToNewGame");
        ToNewButton.SetActive(false);
        FindingCall_DiaryPages();
        Disable_DiaryPages();
        NewGameButtonVisibility();
        //Debug.Log(S_SceneManagement._SceneIndex);
    }

//UPDATE
    void Update()
    {
        
    }

    //FUNCTIONS

    public void NextPage()
    {
        if (_PageCounter != 16)
        {
            _PageCounter++;           
            Debug.Log(_PageCounter);
            A_DiaryPages[_PageCounter].SetActive(true);
            A_DiaryPages[_PageCounter - 1].SetActive(false);
        }     
        

    }

    public void PriorPage()
    {
        if (_PageCounter > 0)
        {
            _PageCounter--;
            Debug.Log(_PageCounter);
            A_DiaryPages[_PageCounter].SetActive(true);
            A_DiaryPages[_PageCounter + 1].SetActive(false);

        }
        
    }

    public void NewGameButtonVisibility()
    {
        DNewGameInt = PlayerPrefs.GetInt("NewGameInt");
        Debug.Log(DNewGameInt);
        if (DNewGameInt == 1)
        {
            ToNewButton.SetActive(true);

        }
        if (DNewGameInt == 0)
        {
            ToNewButton.SetActive(false);
        }

    }
    
    public void NewGameButton()
    {
        SceneManager.LoadScene("MainScene");

    }



    /*public void PreviousSceneBack()
    {
        if (SceneManager.GetActiveScene().buildIndex - S_SceneManagement._SceneIndex == 1)
        {
            //DiaryScene == 2
            //if activesceneindex(Diary == 2) - _SceneIndex == 1 -> previousScene: mainscene -> 2 - 1 == 1
            //if activesceneindex(Diary == 2) - _SceneIndex == 2 -> previousScene: gamemnu -> 2 - 0 == 2           
            Debug.Log("LoadGame");            
            SceneManager.LoadScene("MainScene");


        }
        else if (SceneManager.GetActiveScene().buildIndex - S_SceneManagement._SceneIndex == 2)
        {
            
            Debug.Log("LoadMenu"); 

            SceneManager.LoadScene("GameMenu");

        }
    }*/

    public void BacktoGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void BacktoMenu()
    {
        SceneManager.LoadScene("GameMenu");
    }

    //FINDING CALLS

    public void FindingCall_DiaryPages()
    {

        for (int i = 0; i < A_DiaryPages.Length; i++)
        {
            A_DiaryPages = GameObject.FindGameObjectsWithTag("DiaryPages");
            
        }
    }

    public void Disable_DiaryPages()
    {
        for (int i = 0; i < A_DiaryPages.Length; i++)
        {
            A_DiaryPages[i].SetActive(false);

        }
        A_DiaryPages[13].SetActive(true);
    }

}
