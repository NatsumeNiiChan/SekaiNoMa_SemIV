using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharaVisual_Name : MonoBehaviour
{
    //Scripts
    [HideInInspector] public Dialog_Text S_Dialog_Text;
    [HideInInspector] public Dialog S_Dialog;

    //Dialog Names
    [HideInInspector]
    public GameObject[] A_Dialog_Names = new GameObject[4];
    [HideInInspector] public TMP_Text Txt_Name;


//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    [Header("Visuals")]
    public SpriteRenderer[] SpriteTakeruVisuals = new SpriteRenderer[10];
    public GameObject[] ObjectTakeruVisuals = new GameObject[10];
    [Space]
    public SpriteRenderer[] SpriteMamoruVisuals = new SpriteRenderer[6];
    public GameObject[] ObjectMamoruVisuals = new GameObject[6];
    [Space]
    public SpriteRenderer[] SpriteNanamiVisuals = new SpriteRenderer[12];
    public GameObject[] ObjectNanamiVisuals = new GameObject[12];


//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

//START
    void Start()
    {
        //Scripts
        S_Dialog_Text = GameObject.Find("DialogManager").GetComponent<Dialog_Text>();
        S_Dialog = GameObject.Find("DialogManager").GetComponent<Dialog>();

        FindingCall_Chara_Visuals();
        Dialog_Names();

        //Txt_Name = GameObject.Find("Name").GetComponent<TMP_Text>();


        Dialog_WhichName();

    }

//UPDATE
    void Update()
    {
        
    }

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    public void Dialog_Names()
    {
        A_Dialog_Names[0] = GameObject.Find("PlayerName");
        A_Dialog_Names[1] = GameObject.Find("TakeruName");
        A_Dialog_Names[2] = GameObject.Find("MamoruName");
        A_Dialog_Names[3] = GameObject.Find("NanamiName");

        for (int i = 0; i < A_Dialog_Names.Length; i++)
        {
            A_Dialog_Names[i].SetActive(false);
        }
    }

//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//FUNCTIONS

    public void Dialog_WhichName()
    {
        //Takeru
        if(S_Dialog._CharacterCounter == 0)
        {
            //General
            if (S_Dialog._DialogCounter == 0)
            {
                if (S_Dialog._Index == 0 ||
                    S_Dialog._Index == 1 ||
                    S_Dialog._Index == 3 ||
                    S_Dialog._Index == 5 ||
                    S_Dialog._Index == 7 ||
                    S_Dialog._Index == 9 ||
                    S_Dialog._Index == 11 ||
                    S_Dialog._Index == 13)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[1].SetActive(true);

                }
                if (S_Dialog._Index == 2 ||
                    S_Dialog._Index == 4 ||
                    S_Dialog._Index == 6 ||
                    S_Dialog._Index == 8 ||
                    S_Dialog._Index == 10 ||
                    S_Dialog._Index == 12)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }
            //Correct
            if (S_Dialog._DialogCounter == 1)
            {
                if (S_Dialog._Index == 1 ||
                    S_Dialog._Index == 3 ||
                    S_Dialog._Index == 5 ||
                    S_Dialog._Index == 7 ||
                    S_Dialog._Index == 9)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[1].SetActive(true);

                }
                if (S_Dialog._Index == 0 ||
                    S_Dialog._Index == 2 ||
                    S_Dialog._Index == 4 ||
                    S_Dialog._Index == 6 ||
                    S_Dialog._Index == 8 ||
                    S_Dialog._Index == 10)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }
            //Wrong
            if (S_Dialog._DialogCounter == 2)
            {
                if (S_Dialog._Index == 1 ||
                    S_Dialog._Index == 3)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[1].SetActive(true);

                }
                if (S_Dialog._Index == 0 ||
                    S_Dialog._Index == 2 ||
                    S_Dialog._Index == 4)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }

        }

        //Mamoru
        if (S_Dialog._CharacterCounter == 1)
        {
            //General
            if (S_Dialog._DialogCounter == 0)
            {
                if (S_Dialog._Index == 0 ||
                    S_Dialog._Index == 2 ||
                    S_Dialog._Index == 4 ||
                    S_Dialog._Index == 6 ||
                    S_Dialog._Index == 8 ||
                    S_Dialog._Index == 10 ||
                    S_Dialog._Index == 12)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[2].SetActive(true);

                }
                if (S_Dialog._Index == 1 ||
                    S_Dialog._Index == 3 ||
                    S_Dialog._Index == 5 ||
                    S_Dialog._Index == 7 ||
                    S_Dialog._Index == 9 ||
                    S_Dialog._Index == 11 ||
                    S_Dialog._Index == 13 ||
                    S_Dialog._Index == 14)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }
            //Correct
            if (S_Dialog._DialogCounter == 1)
            {
                if (S_Dialog._Index == 1 ||
                    S_Dialog._Index == 3 ||
                    S_Dialog._Index == 5 ||
                    S_Dialog._Index == 7 ||
                    S_Dialog._Index == 9 ||
                    S_Dialog._Index == 11 ||
                    S_Dialog._Index == 13 ||
                    S_Dialog._Index == 15)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[2].SetActive(true);

                }
                if (S_Dialog._Index == 0 ||
                    S_Dialog._Index == 2 ||
                    S_Dialog._Index == 4 ||
                    S_Dialog._Index == 6 ||
                    S_Dialog._Index == 8 ||
                    S_Dialog._Index == 10 ||
                    S_Dialog._Index == 12 ||
                    S_Dialog._Index == 14)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }
            //Wrong
            if (S_Dialog._DialogCounter == 2)
            {
                if (S_Dialog._Index == 1 ||
                    S_Dialog._Index == 3)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[2].SetActive(true);

                }
                if (S_Dialog._Index == 0 ||
                    S_Dialog._Index == 2 ||
                    S_Dialog._Index == 4)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }

        }

        //Nanami
        if (S_Dialog._CharacterCounter == 2)
        {
            //General
            if (S_Dialog._DialogCounter == 0)
            {
                if (S_Dialog._Index == 0 ||
                    S_Dialog._Index == 2 ||
                    S_Dialog._Index == 4 ||
                    S_Dialog._Index == 6 ||
                    S_Dialog._Index == 8 ||
                    S_Dialog._Index == 10)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[3].SetActive(true);

                }
                if (S_Dialog._Index == 1 ||
                    S_Dialog._Index == 3 ||
                    S_Dialog._Index == 5 ||
                    S_Dialog._Index == 7 ||
                    S_Dialog._Index == 9 ||
                    S_Dialog._Index == 11 ||
                    S_Dialog._Index == 12)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }
            //Correct
            if (S_Dialog._DialogCounter == 1)
            {
                if (S_Dialog._Index == 1 ||
                    S_Dialog._Index == 2 ||
                    S_Dialog._Index == 4 ||
                    S_Dialog._Index == 6 ||
                    S_Dialog._Index == 7)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[3].SetActive(true);

                }
                if (S_Dialog._Index == 0 ||
                    S_Dialog._Index == 3 ||
                    S_Dialog._Index == 5)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }
            //Wrong
            if (S_Dialog._DialogCounter == 2)
            {
                if (S_Dialog._Index == 1 ||
                    S_Dialog._Index == 2)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[3].SetActive(true);

                }
                if (S_Dialog._Index == 0)
                {
                    for (int i = 0; i < A_Dialog_Names.Length; i++)
                    {
                        A_Dialog_Names[i].SetActive(false);
                    }
                    A_Dialog_Names[0].SetActive(true);

                }

            }

        }
    }

    public void Dialog_Visual()
    {
        //Takeru
        if (S_Dialog._CharacterCounter == 0)
        {
            //General
            if (S_Dialog._DialogCounter == 0)
            {
                if (S_Dialog._Index == 0 ) /* 2.1 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[8].enabled = true;

                }
                if (S_Dialog._Index == 1 || S_Dialog._Index == 4) /* 1.1 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[0].enabled = true;

                }
                if (S_Dialog._Index == 2 || S_Dialog._Index == 13) /* 2.2 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[0].enabled = true;
                }
                if (S_Dialog._Index == 3) /* 1.2 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[1].enabled = true;
                }
                if (S_Dialog._Index == 5) /* 1.5 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[4].enabled = true;
                }
                if (S_Dialog._Index == 6 || S_Dialog._Index == 8 || S_Dialog._Index == 10) /* 1.4 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[3].enabled = true;
                }
                if (S_Dialog._Index == 7 || S_Dialog._Index == 9) /* 1.6 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[5].enabled = true;
                }
                if (S_Dialog._Index == 11) /* 1.7 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[6].enabled = true;
                }
                if (S_Dialog._Index == 12) /* 1.8 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[7].enabled = true;
                }
            }
            //Correct
            if (S_Dialog._DialogCounter == 1)
            {
                if (S_Dialog._Index == 0 || S_Dialog._Index == 2 || S_Dialog._Index == 8) /* 1.8 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[7].enabled = true;

                }
                if (S_Dialog._Index == 1 || S_Dialog._Index == 7) /* 1.7 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[6].enabled = true;

                }
                if (S_Dialog._Index == 3) /* 1.6 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[5].enabled = true;

                }
                if (S_Dialog._Index == 4 || S_Dialog._Index == 6) /* 1.3 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[3].enabled = true;

                }
                if (S_Dialog._Index == 5) /* 1.5 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[4].enabled = true;

                }
                if (S_Dialog._Index == 9 || S_Dialog._Index == 10) /* GONE */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }

                }

            }
            //Wrong
            if (S_Dialog._DialogCounter == 2)
            {
                if (S_Dialog._Index == 0 || S_Dialog._Index == 2) /* 1.8 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[7].enabled = true;
                }
                if (S_Dialog._Index == 1) /* 1.7 */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    }
                    SpriteTakeruVisuals[6].enabled = true;

                }
                if (S_Dialog._Index == 3 || S_Dialog._Index == 4) /* GONE */
                {
                    for (int i = 0; i < SpriteTakeruVisuals.Length; i++)
                    {
                        SpriteTakeruVisuals[i].enabled = false;
                    };

                }

            }


        }

        //Mamoru
        if (S_Dialog._CharacterCounter == 1)
        {
            //General
            if (S_Dialog._DialogCounter == 0)
            {
                if (S_Dialog._Index == 0 || S_Dialog._Index == 1 || S_Dialog._Index == 3 || S_Dialog._Index == 11 || S_Dialog._Index == 12 || S_Dialog._Index == 13 || S_Dialog._Index == 14) /* 2.3 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[5].enabled = true;
                }
                if (S_Dialog._Index == 2) /* 2.2 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[4].enabled = true;
                }
                if (S_Dialog._Index == 8 || S_Dialog._Index == 9 || S_Dialog._Index == 10) /* 2.1 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[3].enabled = true;
                }
                if (S_Dialog._Index == 5 || S_Dialog._Index == 6 || S_Dialog._Index == 7) /* 1.1 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[0].enabled = true;
                }
                if (S_Dialog._Index == 4) /* 1.2 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[1].enabled = true;

                }

            }
            //Correct
            if (S_Dialog._DialogCounter == 1)
                {
                    if (S_Dialog._Index == 0) /* 1.1 */
                    {
                        for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                        {
                            SpriteMamoruVisuals[i].enabled = false;
                        }
                        SpriteMamoruVisuals[0].enabled = true;
                    }
                    if (S_Dialog._Index == 12 || S_Dialog._Index == 13 || S_Dialog._Index == 14) /* 1.2 */
                    {
                        for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                        {
                            SpriteMamoruVisuals[i].enabled = false;
                        }
                        SpriteMamoruVisuals[1].enabled = true;
                    }
                    if (S_Dialog._Index == 1 || S_Dialog._Index == 2) /* 1.3 */
                    {
                        for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                        {
                            SpriteMamoruVisuals[i].enabled = false;
                        }
                        SpriteMamoruVisuals[2].enabled = true;
                    }
                    if (S_Dialog._Index == 3 || S_Dialog._Index == 4 || S_Dialog._Index == 11) /* 2.1 */
                    {
                        for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                        {
                            SpriteMamoruVisuals[i].enabled = false;
                        }
                        SpriteMamoruVisuals[3].enabled = true;
                    }
                    if (S_Dialog._Index == 7 || S_Dialog._Index == 8) /* 2.2 */
                    {
                        for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                        {
                            SpriteMamoruVisuals[i].enabled = false;
                        }
                        SpriteMamoruVisuals[4].enabled = true;
                    }
                    if (S_Dialog._Index == 5 || S_Dialog._Index == 6 || S_Dialog._Index == 9 || S_Dialog._Index == 10) /* 2.3 */
                    {
                        for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                        {
                            SpriteMamoruVisuals[i].enabled = false;
                        }
                        SpriteMamoruVisuals[5].enabled = true;
                    }
                    if (S_Dialog._Index == 15) /* LEAF */
                    {
                        for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                        {
                            SpriteMamoruVisuals[i].enabled = false;
                        }
                    }
            }
            //Wrong
            if (S_Dialog._DialogCounter == 2)
            {
                if (S_Dialog._Index == 0) /* 1.1 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[0].enabled = true;
                }
                if (S_Dialog._Index == 1 || S_Dialog._Index == 2) /* 1.3 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[2].enabled = true;
                }
                if (S_Dialog._Index == 6) /* 1.2 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[1].enabled = true;
                }
                if (S_Dialog._Index == 3 || S_Dialog._Index == 4) /* 2.1 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[4].enabled = true;
                }
                if (S_Dialog._Index == 5) /* 2.3 */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                    SpriteMamoruVisuals[5].enabled = true;
                }
                if (S_Dialog._Index == 7) /* LEAF */
                {
                    for (int i = 0; i < SpriteMamoruVisuals.Length; i++)
                    {
                        SpriteMamoruVisuals[i].enabled = false;
                    }
                }
            }
            

        }

        //Nanami
        if (S_Dialog._CharacterCounter == 2)
        {
            //General
            if (S_Dialog._DialogCounter == 0)
            {
                SpriteNanamiVisuals[2].enabled = true;

                if (S_Dialog._Index == 0 || S_Dialog._Index == 1 || S_Dialog._Index == 11 || S_Dialog._Index == 12) /* 1.3 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[2].enabled = true;
                }
                if (S_Dialog._Index == 2 || S_Dialog._Index == 8) /* 1.4 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[3].enabled = true;
                }
                if (S_Dialog._Index == 10) /* 1.6 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[5].enabled = true;
                }
                if (S_Dialog._Index == 6 || S_Dialog._Index == 7) /* 2.1 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[6].enabled = true;
                }
                if (S_Dialog._Index == 3) /* 2.3 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[8].enabled = true;
                }
                if (S_Dialog._Index == 4) /* 2.5 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[10].enabled = true;
                }
                if (S_Dialog._Index == 5) /* 2.6 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[11].enabled = true;
                }

            }
            //Correct
            if (S_Dialog._DialogCounter == 1)
            {
                if (S_Dialog._Index == 0 || S_Dialog._Index == 2) /* 1.3 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[2].enabled = true;
                }
                if (S_Dialog._Index == 1) /* 1.5 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[4].enabled = true;
                }
                if (S_Dialog._Index == 3) /* 2.1 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[6].enabled = true;
                }
                if (S_Dialog._Index == 4) /* 2.2 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[7].enabled = true;
                }
                if (S_Dialog._Index == 5) /* 2.3 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[8].enabled = true;
                }
                if (S_Dialog._Index == 6) /* 2.4 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[9].enabled = true;
                }
                if (S_Dialog._Index == 7) /* LEAVE */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                }
            }
            //Wrong
            if (S_Dialog._DialogCounter == 2)
            {
                if (S_Dialog._Index == 0) /* 1.3 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[2].enabled = true;
                }
                if (S_Dialog._Index == 1) /* 1.5 */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                    SpriteNanamiVisuals[7].enabled = true;
                }
                if (S_Dialog._Index == 2) /* LEAVES */
                {
                    for (int i = 0; i < SpriteNanamiVisuals.Length; i++)
                    {
                        SpriteNanamiVisuals[i].enabled = false;
                    }
                }
            }


        }
        

    }


//+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
//FINDING CALLS

    public void FindingCall_Chara_Visuals()
    {

        ObjectTakeruVisuals = GameObject.FindGameObjectsWithTag("Takeru");
        for (int i = 0; i < ObjectTakeruVisuals.Length; i++)
        {
            SpriteTakeruVisuals[i] = ObjectTakeruVisuals[i].GetComponent<SpriteRenderer>();
            SpriteTakeruVisuals[i].enabled = false;
        }
       

        ObjectMamoruVisuals = GameObject.FindGameObjectsWithTag("Mamoru");
        for (int i = 0; i < ObjectMamoruVisuals.Length; i++)
        {
            SpriteMamoruVisuals[i] = ObjectMamoruVisuals[i].GetComponent<SpriteRenderer>();
            SpriteMamoruVisuals[i].enabled = false;
        }

        ObjectNanamiVisuals = GameObject.FindGameObjectsWithTag("Nanami");
        for (int i = 0; i < ObjectNanamiVisuals.Length; i++)
        {
            SpriteNanamiVisuals[i] = ObjectNanamiVisuals[i].GetComponent<SpriteRenderer>();
            SpriteNanamiVisuals[i].enabled = false;
        }

        SpriteTakeruVisuals[8].enabled = true;

    }

}
