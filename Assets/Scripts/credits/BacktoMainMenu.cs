using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoMainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BackMainMenu();   
    }

    public void BackMainMenu()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SceneManager.LoadScene("GameMenu");

        }

    }

}
