using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.UI;

public class MouseRay : MonoBehaviour
{
    private Camera _MainCamera;

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //Scripts
    [HideInInspector] public Dialog S_Dialog;



    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //CUPBOARD
    private GameObject[] A_CupboardDoor = new GameObject[6];
    private bool[] A_CupboardDoorClosed = new bool[6];
    Vector3[] A_DoorVanillaPosition;
    //Animation
    private Animator[] A_CD_Animators   = new Animator[6];
    
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //INGREDIENTS
    [Header("+++DO NOT EDIT - ONLY LOOK +++")]
    public GameObject[] A_IngredientList       = new GameObject[12]; /*Keep visible to make sure their order is correct*/
    public GameObject[] A_ToolList             = new GameObject[7];
    private bool[] A_IngredientChosen          = new bool[12];
    private bool[] A_ToolChosen                = new bool[3]; /*0=Broth, 1=Soba, 2= Udon*/
    public SpriteRenderer[] A_IngredientSprite = new SpriteRenderer[12];
    //Animations
    private Animator[] A_Ingredient_Animators  = new Animator[12];
    private Animator[] A_Tool_Animators         = new Animator[2];

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //CHARACTERS

    [HideInInspector]
    public Animator TakeruStartAnimator; 
    [HideInInspector] 
    public Animator MamoruStartAnimator; 
    [HideInInspector] 
    public Animator NanamiStartAnimator;




    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    //RECIPE
    public int _IngredientCounter; /* Recipes have 10 ingredients */
    //Which ramen?
    [HideInInspector] public bool _KikakuRamen;
    [HideInInspector] public bool _TonbaraRamen;
    private bool _KikakuCorrect;
    private bool _TonbaraCorrect;
    //Recipe UI
    private GameObject _RecipeOvergroup;
    private GameObject _KikakuUI;
    private GameObject _TonbaraUI;

    private Button B_Serve;


    private GameObject RamenProgress;
    private GameObject TonbaraDone;
    private GameObject KikakuDone;


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //TALKING
    //Box that text is in and is clicked to do the talky 

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //START
    void Awake()
    {

        _MainCamera = Camera.main;
        S_Dialog = GameObject.Find("DialogManager").GetComponent<Dialog>();

        //Recipe UI
        FindingCall_RecipesUI();

        //Get Cupboard Doors
        A_CupboardDoor = GameObject.FindGameObjectsWithTag("Cupboard_Door");
        //Find Cupboard Animator
        FindingCall_CD_Animators();

        //Get Ingredients
        A_IngredientList = GameObject.FindGameObjectsWithTag("Ingredient");
        A_ToolList = GameObject.FindGameObjectsWithTag("Tool");
        //Find Ingredient Animator
        FindingCall_Ingredient_Animators();
        FindingCall_Tool_Animators();
        FindingCall_Ingredient_Sprite();

        //Characters
        FindingCall_Chara_Animators();

        //_DontDestroyObject = GameObject.Find("_DontDestroyObject");



        //Set Cupboard_Doors Vanilla Positions
        A_DoorVanillaPosition = A_CupboardDoor.Select(p => p.transform.position).ToArray();

    }

//UPDATE
    void Update()
    {
        ObjectDetectionbyMouse();
        CloseUI();

        ServeButton();
        
    }

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//FUNCTIONS

    public void ObjectDetectionbyMouse()
    {


        if (Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log($"{hit.collider.name}Detected", hit.collider.gameObject);


                //When one of the cupboard doors was hit
                //1) Move it
                //2) Set the Bool Closed to false
                //-> later on check the bool first, then move it and change bool accordingly
                for (int i = 0; i < A_CupboardDoor.Length; i++)
                {
                    if (hit.collider.gameObject == A_CupboardDoor[i] && A_CupboardDoor[i].transform.position == A_DoorVanillaPosition[i])
                    {
                        A_CupboardDoorClosed[i] = false;
                        //Debug.Log(A_CupboardDoorClosed[i]);
                        //Animation: Move Door Aside     (first check which door was hit, so the right animation can be played)
                        if (hit.collider.gameObject == A_CupboardDoor[0]) /*Top Left*/
                        {
                            A_CD_Animators[0].SetTrigger("CD_Top_l_open");
                        }
                        if (hit.collider.gameObject == A_CupboardDoor[1]) /*Top Right*/
                        {
                            A_CD_Animators[1].SetTrigger("CD_Top_r_open");
                        }
                        else if (hit.collider.gameObject == A_CupboardDoor[2]) /*Mid Left*/
                        {
                            A_CD_Animators[2].SetTrigger("CD_Mid_l_open");
                        }
                        else if (hit.collider.gameObject == A_CupboardDoor[3]) /*Mid Right*/
                        {
                            A_CD_Animators[3].SetTrigger("CD_Mid_r_open");
                        }
                        else if (hit.collider.gameObject == A_CupboardDoor[4]) /*Down Left*/
                        {
                            A_CD_Animators[4].SetTrigger("CD_Down_l_open");
                        }
                        else if (hit.collider.gameObject == A_CupboardDoor[5]) /*Down Right*/
                        {
                            A_CD_Animators[5].SetTrigger("CD_Down_r_open");
                        }

                    }
                    if (hit.collider.gameObject == A_CupboardDoor[i] && A_CupboardDoor[i].transform.position != A_DoorVanillaPosition[i])
                    {
                        A_CupboardDoorClosed[i] = true;
                        //Debug.Log(A_CupboardDoorClosed[i]);
                        //Animation: Close Door
                        if (hit.collider.gameObject == A_CupboardDoor[0]) /*Top Left*/
                        {
                            A_CD_Animators[0].SetTrigger("CD_Top_l_closed");
                        }
                        if (hit.collider.gameObject == A_CupboardDoor[1]) /*Top Right*/
                        {
                            A_CD_Animators[1].SetTrigger("CD_Top_r_closed");
                        }
                        else if (hit.collider.gameObject == A_CupboardDoor[2]) /*Mid Left*/
                        {
                            A_CD_Animators[2].SetTrigger("CD_Mid_l_closed");
                        }
                        else if (hit.collider.gameObject == A_CupboardDoor[3]) /*Mid Right*/
                        {
                            A_CD_Animators[3].SetTrigger("CD_Mid_r_closed");
                        }
                        else if (hit.collider.gameObject == A_CupboardDoor[4]) /*Down Left*/
                        {
                            A_CD_Animators[4].SetTrigger("CD_Down_l_closed");
                        }
                        else if (hit.collider.gameObject == A_CupboardDoor[5]) /*Down Right*/
                        {
                            A_CD_Animators[5].SetTrigger("CD_Down_r_closed");
                        }

                    }
                }

                //COOKING
                if (_IngredientCounter < 9)
                {
                    for (int i = 0; i < A_IngredientList.Length; i++)
                    {
                        if (hit.collider.gameObject == A_IngredientList[i])
                        {
                            if (hit.collider.gameObject == A_IngredientList[0]) /*Egg*/
                            {
                                A_Ingredient_Animators[0].SetTrigger("Egg");
                                A_IngredientSprite[0].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[0] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[1]) /*Lotus*/
                            {
                                A_Ingredient_Animators[1].SetTrigger("Lotus");
                                A_IngredientSprite[1].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[1] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[2]) /*Meat*/
                            {
                                A_Ingredient_Animators[2].SetTrigger("Meat");
                                A_IngredientSprite[2].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[2] = true;
                                _IngredientCounter++;
                                Debug.Log("Porkanim");

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[3]) /*Menma*/
                            {
                                A_Ingredient_Animators[3].SetTrigger("Menma");
                                A_IngredientSprite[3].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[3] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[4]) /*Naruto*/
                            {
                                A_Ingredient_Animators[4].SetTrigger("Naruto");
                                A_IngredientSprite[4].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[4] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[5]) /*Nori*/
                            {
                                A_Ingredient_Animators[5].SetTrigger("Nori");
                                A_IngredientSprite[5].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[5] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[6]) /*PakChoi*/
                            {
                                A_Ingredient_Animators[6].SetTrigger("PakChoi");
                                A_IngredientSprite[6].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[6] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[7]) /*PorkBelly*/
                            {
                                A_Ingredient_Animators[7].SetTrigger("PorkBelly");
                                A_IngredientSprite[7].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[7] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[8]) /*Shiitake*/
                            {
                                A_Ingredient_Animators[8].SetTrigger("Shiitake");
                                A_IngredientSprite[8].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[8] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[9]) /*SojaBean*/
                            {
                                A_Ingredient_Animators[9].SetTrigger("SojaBean");
                                A_IngredientSprite[9].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[9] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[10]) /*Scallions*/
                            {
                                A_Ingredient_Animators[10].SetTrigger("Scallions");
                                A_IngredientSprite[10].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[10] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_IngredientList[11]) /*Wakame*/
                            {
                                A_Ingredient_Animators[11].SetTrigger("Wakame");
                                A_IngredientSprite[11].sortingLayerName = "Ingredients_Out";
                                A_IngredientChosen[11] = true;
                                _IngredientCounter++;

                                RamenVisualProgress();
                            }
                        }

                    }

                    for (int i = 0; i < A_ToolList.Length; i++)
                    {
                        if (hit.collider.gameObject == A_ToolList[i])
                        {
                            if (hit.collider.gameObject == A_ToolList[0]) /*PotNoodles*/
                            {
                                if (_KikakuRamen == true)
                                {
                                    A_Tool_Animators[1].SetTrigger("GetKikakuSoba");
                                    if (A_Tool_Animators[1].GetBool("DisableEmptyK") == true)
                                    {
                                        A_ToolList[6].SetActive(false);
                                    }
                                    RamenVisualProgress();
                                }
                                else if (_TonbaraRamen == true)
                                {
                                    A_Tool_Animators[1].SetTrigger("GetTonbaraUdon");
                                    if (A_Tool_Animators[1].GetBool("DisableEmptyT") == true)
                                    {
                                        A_ToolList[6].SetActive(false);
                                    }
                                    RamenVisualProgress();
                                }
                                
                                //A_Tool_Animators[0].SetTrigger("FillNoodles");
                                //A_ToolChosen[0] = true;
                                //1.Click on Pot  2.animation to fill kelle  3.kelle moves back to wall
                                //4.Click on Kelle to move to bowl and finish

                            }
                            if (hit.collider.gameObject == A_ToolList[1]) /*PotBeefBroth*/
                            {
                                A_Tool_Animators[0].SetTrigger("FillBroth");
                                //A_ToolChosen[1] = true;
                                if (A_Tool_Animators[0].GetBool("DisableEmpty") == true)
                                {
                                    A_ToolList[3].SetActive(false);
                                }

                                RamenVisualProgress();

                            }
                            if (hit.collider.gameObject == A_ToolList[2]) /*HishakuFull*/
                            {
                                A_Tool_Animators[0].SetTrigger("FillBowl");
                                A_ToolChosen[0] = true; 
                                _IngredientCounter++;


                                RamenVisualProgress();

                            }
                            if (hit.collider.gameObject == A_ToolList[3]) /*HishakuEmpty*/
                            {
                                //A_Tool_Animators[3].SetTrigger("HishakuFull");                                
                                //_IngredientCounter++;
                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_ToolList[4]) /*TeboKikakuSoba*/ 
                            {
                                A_Tool_Animators[1].SetTrigger("FillKikakuSoba");
                                A_ToolChosen[1] = true;
                                _IngredientCounter++;
                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_ToolList[5]) /*TeboTonbaraUdon*/
                            {
                                A_Tool_Animators[1].SetTrigger("FillTonbaraUdon");
                                A_ToolChosen[2] = true;
                                _IngredientCounter++;
                                RamenVisualProgress();
                            }
                            if (hit.collider.gameObject == A_ToolList[6]) /*TeboEmpty*/
                            {
                                //A_Tool_Animators[6].SetTrigger("TeboUdon");
                                //A_ToolChosen[6] = true;
                                //_IngredientCounter++;
                                RamenVisualProgress();
                            }

                        }



                    }

                }

                /*TALKING
                if (hit.collider.gameObject == S_Dialog._TextBox)
                {
                    Debug.Log($"{hit.collider.name}Detected", hit.collider.gameObject);

                    
                    /*if (_DialogCounter == 1)
                    {
                        //S_Dialog.

                    }
                    if (_DialogCounter == 2)
                    {
                        //S_Dialog.

                    }




                }*/

            }
        }
    }


//SMOL
    public void Serve_Kikaku()
    {
        if (_IngredientCounter == 9 && _KikakuRamen == true)
        {
            Debug.Log(_KikakuRamen);
            if (A_ToolChosen[1] && A_ToolChosen[0] && A_IngredientChosen[0] && A_IngredientChosen[5] && A_IngredientChosen[9] && A_IngredientChosen[1] && A_IngredientChosen[10] && A_IngredientChosen[2] && A_IngredientChosen[4])
            {
                _KikakuCorrect = true;
                _IngredientCounter = 0;
                Debug.Log("Kikaku Correct");
                S_Dialog._DialogCounter = 1;

                S_Dialog._Index = 0;
            }
            else 
            {
                _KikakuCorrect = false;
                _IngredientCounter = 0;
                Debug.Log("Kikaku Wrong");
                S_Dialog._DialogCounter = 2;

                S_Dialog._Index = 0;

            }

        }
        //Kikaku:
        //Egg, Nori, SojaBean, Lotus, Scallions, Meat, Naruto
        //Pot_Noodles: Soba, BeefBroth, NoodleWater

    }

    public void Serve_Tonbara()
    {
        if (_IngredientCounter == 9 && _TonbaraRamen == true)
        {
            Debug.Log(_TonbaraRamen);
            if (A_ToolChosen[2] && A_ToolChosen[0] && A_IngredientChosen[0] && A_IngredientChosen[5] && A_IngredientChosen[9] && A_IngredientChosen[1] && A_IngredientChosen[10] && A_IngredientChosen[7] && A_IngredientChosen[4])
            {
                _TonbaraCorrect = true;
                _IngredientCounter = 0;
                S_Dialog._DialogCounter = 1;
                Debug.Log("Tonbara Correct");

                S_Dialog._Index = 0;

            }
            else 
            {
                _TonbaraCorrect = false;
                _IngredientCounter = 0;
                Debug.Log("Tonbara Wrong");
                S_Dialog._DialogCounter = 2;

                S_Dialog._Index = 0;
                
            }

        }
        //Tonbara:
        //Egg, Nori, SojaBean, Lotus, Scallions, PorkBelly, Naruto
        //Pot_Noodles: Udon, BeefBroth, NoodleWater
    }

    public void ServeButton()
    {
        if (_IngredientCounter == 9)
        {
            B_Serve.interactable = true;

        }
        else if (_IngredientCounter < 9)
        {
            B_Serve.interactable = false;
        }

    }

    public void RecipeUI()
    {
        Debug.Log("Recipe on");
        if (_KikakuRamen == true)
        {
            _RecipeOvergroup.SetActive(true);
            _KikakuUI.SetActive(true);
            _TonbaraUI.SetActive(false);

        }
        if (_TonbaraRamen == true)
        {
            _RecipeOvergroup.SetActive(true);
            _TonbaraUI.SetActive(true);
            _KikakuUI.SetActive(false);
        }

    }

    public void CloseUI()
    {
        if(Input.GetKeyDown(KeyCode.X))
        {
            _RecipeOvergroup.SetActive(false);

        }


    }


    public void RamenVisualProgress()
    {
        if (_IngredientCounter == 0)
        {
            RamenProgress.SetActive(false);
            TonbaraDone.SetActive(false);
            KikakuDone.SetActive(false);
        }
        if (_IngredientCounter > 0)
        {
            RamenProgress.SetActive(true);
        }
        if (_IngredientCounter == 9)
        {
            RamenProgress.SetActive(false);
            if (_KikakuRamen == true)
            {
                KikakuDone.SetActive(false);
            }
            if (_TonbaraRamen == true)
            {
                TonbaraDone.SetActive(false);
            }
            
            

        }



    }





    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //Finding Calls and Vanilla Positions

    public void FindingCall_CD_Animators()
    {

        for (int i = 0; i < A_CD_Animators.Length; i++)
        {
            A_CD_Animators[i] = A_CupboardDoor[i].GetComponent<Animator>();
            
        }


    }

    public void FindingCall_Ingredient_Sprite()
    {

        for (int i = 0; i < A_IngredientSprite.Length; i++)
        {
            A_IngredientSprite[i] = A_IngredientList[i].GetComponent<SpriteRenderer>();

        }

        RamenProgress = GameObject.Find("Progress");
        RamenProgress.SetActive(false);
        TonbaraDone = GameObject.Find("TonbaraDone");
        TonbaraDone.SetActive(false);
        KikakuDone = GameObject.Find("KikakuDone");
        KikakuDone.SetActive(false);

    }
    public void FindingCall_Ingredient_Animators()
    {

        for (int i = 0; i < A_Ingredient_Animators.Length; i++)
        {
            A_Ingredient_Animators[i] = A_IngredientList[i].GetComponent<Animator>();
            
        }


    }

    public void FindingCall_Tool_Animators()
    {
        A_Tool_Animators[0] = GameObject.Find("Hishaku").GetComponent<Animator>();
        A_Tool_Animators[1] = GameObject.Find("Tebo").GetComponent<Animator>();
        

    }
    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    public void FindingCall_Chara_Animators()
    {
        TakeruStartAnimator = GameObject.Find("Takeru2.1_Start").GetComponent<Animator>();
        MamoruStartAnimator = GameObject.Find("Mamoru2.3_Start").GetComponent<Animator>();
        NanamiStartAnimator = GameObject.Find("Nanami1.3_Start").GetComponent<Animator>();

    }
    



    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    public void FindingCall_RecipesUI()
    {
        //_RecipeOvergroup = GameObject.Find("Recipes");
        _KikakuUI = GameObject.Find("Recipe_Kikaku");
        _TonbaraUI = GameObject.Find("Recipe_Tonbara");
        _RecipeOvergroup = GameObject.FindGameObjectWithTag("RecipeOvergroup");
        _KikakuUI.SetActive(false);
        _TonbaraUI.SetActive(false);
        _RecipeOvergroup.SetActive(false);

        B_Serve = GameObject.Find("B_Serve").GetComponent<Button>();
        B_Serve.interactable = false;
    }
}

