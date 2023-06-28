using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [HideInInspector] public int _SceneIndex;


    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    //START
    void Start()
    {

    }

//UPDATE
    void Update()
    {
        
    }


    //FUNCTIONS

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }




}
