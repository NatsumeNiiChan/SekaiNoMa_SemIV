using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    [HideInInspector] public int _SceneIndex;

    private void Awake()
    {
        
        
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

    public void GotoCutscene()
    {
        SceneManager.LoadScene("EndCutscene");

    }


}
