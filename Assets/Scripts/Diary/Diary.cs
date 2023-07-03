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


//START
    void Start()
    {
        S_SceneManagement = GameObject.Find("GameManager").GetComponent<SceneManagement>();

        FindingCall_DiaryPages();
        Disable_DiaryPages();

        Debug.Log(S_SceneManagement._SceneIndex);
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



    public void PreviousSceneBack()
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
        for (int i = 1; i < A_DiaryPages.Length; i++)
        {
            A_DiaryPages[i].SetActive(false);

        }
    }

}
