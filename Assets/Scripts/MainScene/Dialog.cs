using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Dialog : MonoBehaviour
{
    //Scripts
    //[HideInInspector] public MouseRay S_MouseRay;
    [HideInInspector] public Dialog_Text S_Dialog_Text;
    [HideInInspector] public MouseRay S_MouseRay;

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    [HideInInspector] public GameObject _TextBox;
    [HideInInspector] public TextMeshProUGUI Txt_Dialog;
    public float _TextSpeed;

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

    //Counters
    [HideInInspector] public int _DialogCounter = 0;
    [HideInInspector] public int _CharacterCounter = 0;
    //Counter for Inside of Single Array
    //[HideInInspector]
    public int _Index = 0;




//START
    void Start()
    {
        //Get Scripts
        //S_MouseRay = GameObject.Find("GameManager").GetComponent<MouseRay>();
        S_Dialog_Text = GameObject.Find("DialogManager").GetComponent<Dialog_Text>();
        S_MouseRay = GameObject.FindWithTag("ManagerMain").GetComponent<MouseRay>();


        //Get Stuff
        _TextBox = GameObject.Find("Text_Box");
        Txt_Dialog = GameObject.Find("Txt_Dialog").GetComponent<TextMeshProUGUI>();
        //_TextBox.SetActive(false);

        PlayerPrefs.SetInt("NewGameInt", 0);

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        _DialogCounter = 0;
        _CharacterCounter = 0;
        _Index = 0;
        Txt_Dialog.text = string.Empty;


        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

        LoadData();
        StartDialog();
        
    }

//UPDATE
    void Update()
    {

        /* if (Input.GetMouseButtonDown(0))
         {
             if (Txt_Dialog.text == A_Lines[_Index])
             {
                 NextLine();
             }
             else
             {
                 StopAllCoroutines();
                 Txt_Dialog.text = A_Lines[_Index];
             }
         }*/
    }


    //FUNCTIONS

    public void StartDialog()
    {
        if (_TextBox.activeSelf)
        {
            if (_CharacterCounter == 0 && _DialogCounter == 0 && _Index == 0) /* Takeru */
            {
                //call animation
                S_MouseRay.TakeruStartAnimator.SetTrigger("TakeruStart");

                S_MouseRay._KikakuRamen = false;
                S_MouseRay._TonbaraRamen = true;
                _DialogCounter = 0;
                StartCoroutine(TypeLine_Takeru());

            }

            if (_CharacterCounter == 1) /* Mamoru */
            {
                //call animation

                S_MouseRay.MamoruStartAnimator.SetTrigger("MamoruStart");


                S_MouseRay._KikakuRamen = true;
                S_MouseRay._TonbaraRamen = false;

                _DialogCounter = 0;

                StartCoroutine(TypeLine_Mamoru());

            }

            if (_CharacterCounter == 2) /* Nanami */
            {
                //call animation
                S_MouseRay.NanamiStartAnimator.SetTrigger("NanamiStart");


                S_MouseRay._KikakuRamen = false;
                S_MouseRay._TonbaraRamen = true;
                _DialogCounter = 0;

                StartCoroutine(TypeLine_Nanami());

            }


        }
        

    }


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // Takeru - Character Counter 0

    public void DialogFunction_Takeru()
    {
        if (_DialogCounter == 0) /* General */
        {
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Takeru_General[_Index])
            {
                NextLine_Takeru();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Takeru_General[_Index];
            }


        }

        if (_DialogCounter == 1) /* Correct */
        {
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Takeru_Correct[_Index])
            {
                NextLine_Takeru();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Takeru_Correct[_Index];
            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {           
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Takeru_Wrong[_Index])
            {
                NextLine_Takeru();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Takeru_Wrong[_Index];
            }
           

            //When last text reached, set chara counter up
        }

    }
    IEnumerator TypeLine_Takeru()
    {
        if (_DialogCounter == 0) /* General */
        {          
            foreach (char c in S_Dialog_Text.A_Dialog_Takeru_General[_Index].ToCharArray())
            {
                //Debug.Log("TypeLineTakeru");
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }

        }

        if (_DialogCounter == 1) /* Correct */
        {
            foreach (char c in S_Dialog_Text.A_Dialog_Takeru_Correct[_Index].ToCharArray())
            {
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {
            foreach (char c in S_Dialog_Text.A_Dialog_Takeru_Wrong[_Index].ToCharArray())
            {
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }
        }
    }
    void NextLine_Takeru()
    {
        if (_DialogCounter == 0) /* General */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Takeru_General.Length - 1)
            {
                //Debug.Log("NextLine");
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Takeru());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Takeru_General.Length - 1)
            {
                Debug.Log(_Index);

                Debug.Log("Dialog-TGeneral End");

            }
        }

        if (_DialogCounter == 1) /* Correct */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Takeru_Correct.Length - 1)
            {
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Takeru());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Takeru_Correct.Length -1)
            {
                Debug.Log(_Index);
                Debug.Log("Dialog-TCorrect End");
                _CharacterCounter = 1;
                _Index = 0;
                StartDialog();

            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Takeru_Wrong.Length - 1)
            {
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Takeru());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Takeru_Wrong.Length -1)
            {
                Debug.Log("Dialog-TWrong End");
                Debug.Log(_Index);
                _CharacterCounter = 1;
                _Index = 0;
                StartDialog();

            }
        }

    }

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // Mamoru - Character Counter 1

    public void DialogFunction_Mamoru()
    {
        if (_DialogCounter == 0) /* General */
        {
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Mamoru_General[_Index])
            {
                NextLine_Mamoru();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Mamoru_General[_Index];
            }
        }

        if (_DialogCounter == 1) /* Correct */
        {
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Mamoru_Correct[_Index])
            {
                NextLine_Mamoru();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Mamoru_Correct[_Index];
            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Mamoru_Wrong[_Index])
            {
                NextLine_Mamoru();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Mamoru_Wrong[_Index];
            }
        }

    }
    IEnumerator TypeLine_Mamoru()
    {
        if (_DialogCounter == 0) /* General */
        {
            foreach (char c in S_Dialog_Text.A_Dialog_Mamoru_General[_Index].ToCharArray())
            {
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }
        }

        if (_DialogCounter == 1) /* Correct */
        {
            foreach (char c in S_Dialog_Text.A_Dialog_Mamoru_Correct[_Index].ToCharArray())
            {
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {
            foreach (char c in S_Dialog_Text.A_Dialog_Mamoru_Wrong[_Index].ToCharArray())
            {
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }
        }
    }
    void NextLine_Mamoru()
    {
        if (_DialogCounter == 0) /* General */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Mamoru_General.Length - 1)
            {
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Mamoru());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Mamoru_General.Length -1)
            {
                Debug.Log("Dialog End");


            }
        }

        if (_DialogCounter == 1) /* Correct */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Mamoru_Correct.Length - 1)
            {
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Mamoru());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Mamoru_Correct.Length -1)
            {
                Debug.Log("Dialog End");
                _CharacterCounter = 2;
                _Index = 0;
                StartDialog();
            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Mamoru_Wrong.Length - 1)
            {
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Mamoru());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Mamoru_Wrong.Length - 1)
            {
                Debug.Log("Dialog End");
                _CharacterCounter = 2;
                _Index = 0;
                StartDialog();
            }
        }

    }

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // Nanami - Character Counter 2

    public void DialogFunction_Nanami()
    {
        if (_DialogCounter == 0) /* General */
        {
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Nanami_General[_Index])
            {
                NextLine_Nanami();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Nanami_General[_Index];
            }
        }

        if (_DialogCounter == 1) /* Correct */
        {
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Nanami_Correct[_Index])
            {
                NextLine_Nanami();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Nanami_Correct[_Index];
            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {
            if (Txt_Dialog.text == S_Dialog_Text.A_Dialog_Nanami_Wrong[_Index])
            {
                NextLine_Nanami();
            }
            else
            {
                StopAllCoroutines();
                Txt_Dialog.text = S_Dialog_Text.A_Dialog_Nanami_Wrong[_Index];
            }
        }

    }
    IEnumerator TypeLine_Nanami()
    {
        if (_DialogCounter == 0) /* General */
        {
            foreach (char c in S_Dialog_Text.A_Dialog_Nanami_General[_Index].ToCharArray())
            {
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }
        }

        if (_DialogCounter == 1) /* Correct */
        {
            foreach (char c in S_Dialog_Text.A_Dialog_Nanami_Correct[_Index].ToCharArray())
            {
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {
            foreach (char c in S_Dialog_Text.A_Dialog_Nanami_Wrong[_Index].ToCharArray())
            {
                Txt_Dialog.text += c;
                yield return new WaitForSeconds(_TextSpeed);
            }
        }
    }
    void NextLine_Nanami()
    {
        if (_DialogCounter == 0) /* General */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Nanami_General.Length - 1)
            {
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Nanami());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Nanami_General.Length - 1)
            {
                Debug.Log("Dialog End");


            }
        }

        if (_DialogCounter == 1) /* Correct */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Nanami_Correct.Length - 1)
            {
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Nanami());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Nanami_Correct.Length - 1)
            {
                Debug.Log("Dialog End");
                _Index = 0;
                // DO THE END OF GAME THINGS?
                SceneManager.LoadScene("MinigameChouHan");
            }
        }

        if (_DialogCounter == 2) /* Wrong */
        {
            if (_Index < S_Dialog_Text.A_Dialog_Nanami_Wrong.Length - 1)
            {
                _Index++;
                Txt_Dialog.text = string.Empty;
                StartCoroutine(TypeLine_Nanami());
            }
            else if (_Index == S_Dialog_Text.A_Dialog_Nanami_Wrong.Length - 1)
            {
                Debug.Log("Dialog End");
                _Index = 0;
                // DO THE END OF GAME THINGS?
                SceneManager.LoadScene("MinigameChouHan");

            }
        }

    }


    public void SaveData()
    {
        PlayerPrefs.SetInt("_Index", _Index);
        PlayerPrefs.SetInt("_CharacterCounter", _CharacterCounter);
        PlayerPrefs.SetInt("_DialogCounter", _DialogCounter);

        //Debug.Log(_Index);
        //Debug.Log(_CharacterCounter);
        //Debug.Log(_DialogCounter);
    }
    public void LoadData()
    {
        _Index = PlayerPrefs.GetInt("_Index");
        _CharacterCounter = PlayerPrefs.GetInt("_CharacterCounter");
        _DialogCounter = PlayerPrefs.GetInt("_DialogCounter");

        //Debug.Log(_Index);
        //.Log(_CharacterCounter);
        //Debug.Log(_DialogCounter);
    }

    public void B_DialogFunction()
    {
        if (_CharacterCounter == 0)
        {
            DialogFunction_Takeru();

        }
        if (_CharacterCounter == 1)
        {
            DialogFunction_Mamoru();

        }
        if (_CharacterCounter == 2)
        {
            DialogFunction_Nanami();

        }
    }
    //FINDING CALLS

}
