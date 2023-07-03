using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CameraPosition : MonoBehaviour
{
    //Scripts
    [HideInInspector]
    public Dialog S_Dialog;


    //Note: Later on change the public to grabbing them automatically at start
    [Header("Camera")]
    private Camera _MainCamera;

    //CameraMovement
    private GameObject B_MovetoCooking;
    private GameObject B_MovetoGuest;

    //Buttons
    private GameObject B_Serve;
    private GameObject B_Recipe;

    


    //Position of the two Backgrounds for GUest and Cooking Scene, which are needed to move the 
    //camera down or up 
    Vector3 GuestCamera = new Vector3(0f, 7.14f, -10f);
    Vector3 CookCamera = new Vector3(0f, -7.25f, -10f);
    



//START
    void Start()
    {
        //DialogScript
        S_Dialog = GameObject.Find("DialogManager").GetComponent<Dialog>();

        _MainCamera = Camera.main;

        //Buttons
        B_MovetoCooking = GameObject.Find("B_Cooking");
        B_MovetoGuest = GameObject.Find("B_Guest");
        B_Serve = GameObject.Find("B_Serve");
        B_Recipe = GameObject.Find("B_Recipe");

        //Other
        B_Serve.SetActive(false);
        B_Recipe.SetActive(false);
        B_MovetoGuest.SetActive(false);

    }

//UPDATE
    void Update()
    {
       


    }



//Functions for Moving the Camera to the Cooking Area
    public void CookingCameraMove()
    {
        StartCoroutine(CookingCameraLogic());
        B_MovetoCooking.SetActive(false);
        B_MovetoGuest.SetActive(true);


        B_Serve.SetActive(true);
        B_Recipe.SetActive(true);

        S_Dialog._TextBox.SetActive(false);
    }

    public IEnumerator CookingCameraLogic()
    {
        float timeSinceStarted = 0f;
        while (_MainCamera.transform.position != CookCamera)
        {
            timeSinceStarted += Time.deltaTime;
            _MainCamera.transform.position = Vector3.Lerp(GuestCamera, CookCamera, timeSinceStarted);
            //Debug.Log("CamMoved");

            // If the object has arrived, stop the coroutine
            if (_MainCamera.transform.position == CookCamera)
            {
                yield break;
            }

            // Otherwise, continue next frame
            yield return null;
        }
    }


//Functions for Moving the Camera to the Guest Area
    public void GuestCameraMove()
    {
        StartCoroutine(GuestCameraLogic());
        B_MovetoCooking.SetActive(true);
        B_MovetoGuest.SetActive(false);

        B_Serve.SetActive(false);
        B_Recipe.SetActive(false);
        S_Dialog._TextBox.SetActive(true);

    }

    public IEnumerator GuestCameraLogic()
    {
        float timeSinceStarted = 0f;
        while (_MainCamera.transform.position != GuestCamera)
        {
            timeSinceStarted += Time.deltaTime;
            _MainCamera.transform.position = Vector3.Lerp(CookCamera, GuestCamera, timeSinceStarted);
            //Debug.Log("CamMoved");

            // If the object has arrived, stop the coroutine
            if (_MainCamera.transform.position == GuestCamera)
            {
                yield break;
            }

            // Otherwise, continue next frame
            yield return null;
        }
    }




//FINDING CALLS

    










}
