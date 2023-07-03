using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Dice : MonoBehaviour
{
    //Scripts
    private MouseRay S_MouseRay;

//VARIABLES

    [Header("Dice")]
    private GameObject[] A_Dice = new GameObject[3];

    [Header("DiceRotation")]
    //Dice Rotations 
    Quaternion Q_Dice_1 = Quaternion.Euler(0, -270, 90);
    Quaternion Q_Dice_2 = Quaternion.Euler(0, 0, 180);
    Quaternion Q_Dice_3 = Quaternion.Euler(-90, -180, 0);
    Quaternion Q_Dice_4 = Quaternion.Euler(90, 0, 0);
    Quaternion Q_Dice_5 = Quaternion.Euler(0, 180, 0);
    Quaternion Q_Dice_6 = Quaternion.Euler(0, 90, -90);

    [Header("Random_Number")]
    private int[] _DiceNumber = new int[3];
    private int   _DiceSum;
    private TMP_Text Txt_DiceSum;

    [Header("Buttons")]
    private GameObject B_Player_Even;
    private GameObject B_Player_Odd;
    private GameObject B_Nanami_Even;
    private GameObject B_Nanami_Odd;
    private GameObject B_NextRound;

    [Header("ScoreCounters")]
    //Red = DANGER | Blue = SAFETY
    private int _PlayerToken_Red = 0;
    private int _PlayerToken_Blue = 10;
    private int _NanamiToken_Red = 10;
    private int _NanamiToken_Blue = 0;
    //ScoreCount Text
    private TMP_Text Txt_PlayerToken_Red;
    private TMP_Text Txt_PlayerToken_Blue;
    private TMP_Text Txt_NanamiToken_Red;
    private TMP_Text Txt_NanamiToken_Blue;

    [Header("EndScreens")]
    private GameObject _Screen_Win;
    private GameObject _Screen_Loss;

    [Header("Bet Results")]
    private TMP_Text Txt_Bet_Nanami;
    private TMP_Text Txt_Bet_Player;

    //Bools for Playerbets
    private bool _Even;
    private bool _Odd;

    //Random Even/Odd bool for nanamis bet
    private bool _Nanami_HasBet;
    private bool _Nanami_Even_Bool;
    private int  _Nanami_Even_Int;

    //bools for whose turn it is to bet first (player always starts in new round, nanami not)
    private bool _PlayerTurn = true;
    private bool _NanamiTurn = false;


//START
    void Start()
    {

    //Finding Calls
        
        //Scripts
        S_MouseRay = GameObject.Find("GameManager").GetComponent<MouseRay>();
        //GameObjects
        FindingCall_Dice();
        //Text
        FindingCall_Txt();
        //Buttons
        FindingCall_Buttons();
        //Other
        FindingCall_Other();


    

    //DISABLE AFTER FINDING CALLS
        //Screens
        _Screen_Loss.SetActive(false);
        _Screen_Win.SetActive(false);
        //Buttons
        B_NextRound.SetActive(false);
        B_Nanami_Even.SetActive(false);
        B_Nanami_Odd.SetActive(false);



    //Other
        //Bets = false;
        _Even = false;
        _Odd = false;
       

    }

//UPDATES
    void Update()
    {

    }


//FUNCTIONS

    //Set Even and Odd bool to true when the respective button is pressed
    public void _Bet_Even()
    {
        _Even = true;
        _Odd = false;
        Txt_Bet_Player.text = "Player bet Even";

    } 
    public void _Bet_Odd()
    {
        _Odd = true;
        _Even = false;
        Txt_Bet_Player.text = "Player bet Odd";

    }


    //PLAYER 
    //Roll Dice if Even or Odd are true (Button has been pressed)
    public void DiceRoll_Player()
    {
        if (_PlayerTurn == true && _NanamiTurn == false)
        {
            

            Debug.Log("Playerturn");            
            //DiceRolling Mechanic
            //Roll when even/odd button clicked
            if (_Even == true || _Odd == true)
            {
                //DiceRollAnimation
                //Disable Even and Odd Buttons
                B_Player_Odd.gameObject.SetActive(false);
                B_Player_Even.gameObject.SetActive(false);

                // When _BetSet(Button clicked) true, then generate numbers (and roll dice)
                // generate random number and place it on _DiceNumber
                // as many dice there are, as many dice numbers shall be generated
                for (int i = 0; i < A_Dice.Length; i++)
                {
                    _DiceNumber[i] = Random.Range(1, 6);
                    //Debug.Log(_DiceNumber[i]);

                }


                //Dice Rotation
                for (int k = 0; k < _DiceNumber.Length; k++)
                {
                    if (_DiceNumber[k] == 1)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_1;
                    }
                    else if (_DiceNumber[k] == 2)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_2;
                    }
                    else if (_DiceNumber[k] == 3)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_3;
                    }
                    else if (_DiceNumber[k] == 4)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_4;
                    }
                    else if (_DiceNumber[k] == 5)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_5;
                    }
                    else if (_DiceNumber[k] == 6)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_6;
                    }
                }


                //Random for Nanamis Bet
                //Random number 1 or 2
                //1 == odd | 2 == even
                _Nanami_Even_Int = Random.Range(1, 3);
                if (_Nanami_Even_Int == 1)
                {
                    _Nanami_Even_Bool = false;
                    //Debug.Log(_Nanami_EvenBool);
                    Txt_Bet_Nanami.text = "Nanami bet Odd";

                }
                else if (_Nanami_Even_Int == 2)
                {
                    _Nanami_Even_Bool = true;
                    //Debug.Log(_Nanami_EvenBool);
                    Txt_Bet_Nanami.text = "Nanami bet Even";

                }




                //Adding Numbers on Dice together and displaying in UI
                foreach (int item in _DiceNumber)
                {
                    _DiceSum += item;

                }


                //Exchanging Tokens/Points between Player + Nanami depending on what they bet


                Txt_DiceSum.text = _DiceSum.ToString();

                //Token Calculations + Endgame
                TokenCalculation();
                FinishMinigame();

                //Next starter is nanami
                _PlayerTurn = false;
                _NanamiTurn = true;

                B_NextRound.gameObject.SetActive(true);

                _DiceSum = 0;
            }

        }
    }

    //NANAMI
    //Roll Dice if Even or Odd are true (Button has been pressed)
    public void DiceRoll_Nanami()
    {
       
       if (_PlayerTurn == false && _NanamiTurn == true && _Nanami_HasBet == true)
       {

            

            //DiceRolling Mechanic
            //Roll when even/odd button clicked
            if (_Even == true || _Odd == true)
            {
                //DiceRollAnimation
                //Disable Even and Odd Buttons
                B_Nanami_Odd.SetActive(false);
                B_Nanami_Even.SetActive(false);

                // When _BetSet(Button clicked) true, then generate numbers (and roll dice)
                // generate random number and place it on _DiceNumber
                // as many dice there are, as many dice numbers shall be generated
                for (int i = 0; i < A_Dice.Length; i++)
                {
                    _DiceNumber[i] = Random.Range(1, 6);
                    //Debug.Log(_DiceNumber[i]);

                }


                //Dice Rotation
                for (int k = 0; k < _DiceNumber.Length; k++)
                {
                    if (_DiceNumber[k] == 1)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_1;
                    }
                    else if (_DiceNumber[k] == 2)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_2;
                    }
                    else if (_DiceNumber[k] == 3)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_3;
                    }
                    else if (_DiceNumber[k] == 4)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_4;
                    }
                    else if (_DiceNumber[k] == 5)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_5;
                    }
                    else if (_DiceNumber[k] == 6)
                    {
                        A_Dice[k].transform.rotation = Q_Dice_6;
                    }
                }


                //Adding Numbers on Dice together and displaying in UI
                foreach (int item in _DiceNumber)
                {
                    _DiceSum += item;

                }

                Txt_DiceSum.text = _DiceSum.ToString();

                //Token Calculations + Endgame
                TokenCalculation();
                FinishMinigame();

                //Next starter is player
                _PlayerTurn = true;
                _NanamiTurn = false;

                _Nanami_HasBet = false;

                //Switch out the Buttons
                

                B_Player_Odd.SetActive(true);
                B_Player_Even.SetActive(true);

                _DiceSum = 0;
            }

        }

    }


    //Nanami Bet when shes first
    public void _NextRoundNanamiBet()
    {
        Debug.Log("Nanamiturn");
        //Random for Nanamis Bet
        //Random number 1 or 2
        //1 == odd | 2 == even
        _Nanami_Even_Int = Random.Range(1, 3);
        if (_Nanami_Even_Int == 1)
        {
            _Nanami_Even_Bool = false;
            //Debug.Log(_Nanami_EvenBool);
            Txt_Bet_Nanami.text = "Nanami bet Odd";

        }
        else if (_Nanami_Even_Int == 2)
        {
            _Nanami_Even_Bool = true;
            //Debug.Log(_Nanami_EvenBool);
            Txt_Bet_Nanami.text = "Nanami bet Even";
        }

        B_Nanami_Odd.SetActive(true);
        B_Nanami_Even.SetActive(true);

        B_NextRound.SetActive(false);

        _Nanami_HasBet = true;

    }



    //Calculate when which person gets how many tokens depending on their bets
    public void TokenCalculation()
    {
        //If DiceSum EVEN
        if (_DiceSum % 2 == 0)
        {
            //Both bet ODD
            if (_Even == false && _Nanami_Even_Bool == false)
            {
                //no trade
                PrintTokenScores();
            }
            //Both bet EVEN
            else if (_Even == true && _Nanami_Even_Bool == true)
            {
                //Player takes two Danger Tokens from Nanami
                //Player gives two Safety Tokens to Nanami
                _PlayerToken_Red += 2;
                _PlayerToken_Blue -= 2;
                //Nanami takes two Safety Tokens from Player
                //Nanami gives two Danger Tokens to Player
                _NanamiToken_Red -= 2;
                _NanamiToken_Blue += 2;
                PrintTokenScores();
            }
            //Player bet Odd, Nanami bet Even -> nanami Won
            else if (_Even == false && _Nanami_Even_Bool == true)
            {
                //Player gives two Safety Tokens to Nanami                
                _PlayerToken_Blue -= 2;

                //Nanami takes two Safety Tokens from Player
                _NanamiToken_Blue += 2;
                PrintTokenScores();
            }
            //Player bet Even, Nanami bet Odd -> player won
            else if (_Even == true && _Nanami_Even_Bool == false)
            {
                //Player takes two Danger Tokens from Nanami
                _PlayerToken_Red += 2;
                //Nanami gives two Danger Tokens to Player
                _NanamiToken_Red -= 2;
                PrintTokenScores();
            }
        }

        //If DiceSum ODD
        else if (_DiceSum % 2 == 1)
        {
            //Both bet EVEN
            if (_Even == true && _Nanami_Even_Bool == true)
            {
                //no trade
                PrintTokenScores();
            }
            //Both bet ODD
            else if (_Even == false && _Nanami_Even_Bool == false)
            {
                //Player takes two Danger Tokens from Nanami
                //Player gives two Safety Tokens to Nanami
                _PlayerToken_Red += 2;
                _PlayerToken_Blue -= 2;
                //Nanami takes two Safety Tokens from Player
                //Nanami gives two Danger Tokens to Player
                _NanamiToken_Red -= 2;
                _NanamiToken_Blue += 2;
                PrintTokenScores();
            }
            //Player bet even, Nanami bet ODD -> nanami won
            else if (_Even == true && _Nanami_Even_Bool == false)
            {
                //Player gives two Safety Tokens to Nanami                
                _PlayerToken_Blue -= 2;

                //Nanami takes two Safety Tokens from Player
                _NanamiToken_Blue += 2;
                PrintTokenScores();
            }
            //Player bet odd, Nanami bet even -> player won
            else if (_Even == false && _Nanami_Even_Bool == true)
            {
                //Player takes two Danger Tokens from Nanami
                _PlayerToken_Red += 2;
                //Nanami gives two Danger Tokens to Player
                _NanamiToken_Red -= 2;
                PrintTokenScores();
            }
        }

    }

    //Write the Token scores into the UI
    public void PrintTokenScores()
    {
        Txt_PlayerToken_Red.text = _PlayerToken_Red.ToString();
        Txt_PlayerToken_Blue.text = _PlayerToken_Blue.ToString();
        Txt_NanamiToken_Red.text = _NanamiToken_Red.ToString();
        Txt_NanamiToken_Blue.text = _NanamiToken_Blue.ToString();

    }

    //Check if the Game has been Won or Lost
    public void FinishMinigame()
    {
        if (_PlayerToken_Red == 10 && _NanamiToken_Blue == 10)
        {
            Debug.Log("Game finished successfully: All Tokens traded");
            _Screen_Win.SetActive(true);
            Invoke("LoadMainScene", 5);
        }
        else if (_PlayerToken_Red == 10 && _PlayerToken_Blue == 10)
        {
            Debug.Log("Game failed: Player has all Tokens");
            _Screen_Loss.SetActive(true);
        }
        else if (_PlayerToken_Red < 0 || _PlayerToken_Blue < 0 || _NanamiToken_Blue < 0 || _NanamiToken_Red < 0)
        {
            Debug.Log("Game failed: No Tokens can be exchanged anymore");
            _Screen_Loss.SetActive(true);

        }
        else if (_NanamiToken_Red == 10 && _NanamiToken_Blue == 10)
        {
            Debug.Log("Game failed: Nanami has all Tokens");
            _Screen_Loss.SetActive(true);
        }
        
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }



//FINDING CALL FUNCTIONS

    public void FindingCall_Dice()
    {
        for (int i = 0; i < A_Dice.Length; i++)
        {
            A_Dice = GameObject.FindGameObjectsWithTag("Dice");

        }
    }

    public void FindingCall_Buttons()
    {
        B_Player_Even = GameObject.Find("B_Player_Even");
        B_Player_Odd = GameObject.Find("B_Player_Odd");

        B_Nanami_Even = GameObject.Find("B_Nanami_Even");
        B_Nanami_Odd = GameObject.Find("B_Nanami_Odd");

        B_NextRound = GameObject.Find("NanamisBet");

    }

    public void FindingCall_Txt()
    {
        //DiceSum
        Txt_DiceSum = GameObject.Find("DiceSum").GetComponent<TMP_Text>();

        //Token_Texts
        Txt_PlayerToken_Red  = GameObject.Find("Player_Red#").GetComponent<TMP_Text>();
        Txt_PlayerToken_Blue = GameObject.Find("Player_Blue#").GetComponent<TMP_Text>();
        Txt_NanamiToken_Red  = GameObject.Find("Nanami_Red#").GetComponent<TMP_Text>();
        Txt_NanamiToken_Blue = GameObject.Find("Nanami_Blue#").GetComponent<TMP_Text>();

        //Bet Results
        Txt_Bet_Nanami = GameObject.Find("Txt_Bet_Nanami").GetComponent<TMP_Text>();
        Txt_Bet_Player = GameObject.Find("Txt_Bet_Player").GetComponent<TMP_Text>();

    }

    public void FindingCall_Other()
    {
        _Screen_Win = GameObject.Find("Screen_Win");
        _Screen_Loss = GameObject.Find("Screen_Loss");

    }

}
