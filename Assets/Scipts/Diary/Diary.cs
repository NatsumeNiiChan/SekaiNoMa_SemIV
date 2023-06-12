using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diary : MonoBehaviour
{
    //Scripts

    //DiaryPages
    public GameObject[] A_DiaryPages = new GameObject[17];

    //Counter
    private int _PageCounter = 0;


//START
    void Start()
    {
        FindingCall_DiaryPages();
        Disable_DiaryPages();
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
