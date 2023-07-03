using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Dialog_Text : MonoBehaviour
{
    //Scripts
    //[HideInInspector]
    //public MouseRay S_MouseRay;

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    //DIALOGUE ARRAYS
    //Takeru
    //delegate void D_DialogsTakeru();

    

    //Dialog Texts
    [HideInInspector] 
    public string[] A_Dialog_Takeru_General = new string[14];
    [HideInInspector]
    public string[] A_Dialog_Takeru_Correct = new string[11];
    [HideInInspector] 
    public string[] A_Dialog_Takeru_Wrong = new string[5];

    [HideInInspector]
    public string[] A_Dialog_Mamoru_General = new string[15];
    [HideInInspector]
    public string[] A_Dialog_Mamoru_Correct = new string[16];
    [HideInInspector]
    public string[] A_Dialog_Mamoru_Wrong = new string[8];

    [HideInInspector] 
    public string[] A_Dialog_Nanami_General = new string[13];
    [HideInInspector]
    public string[] A_Dialog_Nanami_Correct = new string[8];
    [HideInInspector]
    public string[] A_Dialog_Nanami_Wrong = new string[3];


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    //START
    void Start()
    {
        //S_MouseRay = GameObject.Find("GameManager").GetComponent<MouseRay>();
        //Dialogue_TakeruGeneral();

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


        Dialog_TakeruGeneral();
        Dialog_TakeruCorrect();
        Dialog_TakeruWrong();

        Dialog_MamoruGeneral();
        Dialog_MamoruCorrect();
        Dialog_MamoruWrong();

        Dialog_NanamiGeneral();
        Dialog_NanamiCorrect();
        Dialog_NanamiWrong();



    }

    //UPDATE
    void Update()
    {

        //A_Dialog_Mamoru_Correct.Add("»Hier, bitte sehr.« ");


    }

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    //FUNCTIONS

    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Names

   


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Takeru

    public void Dialog_TakeruGeneral() /* Dialogue || 1 || */
    {
        Debug.Log(A_Dialog_Takeru_General.Length);

        //Takeru enters Restaurant
        //CharaCount=0 Index=0-13 DialogCount=0

        /*T 2.1 = [8]*/ A_Dialog_Takeru_General[0]  = "»Hey!« ";  
        /*T 1.1 = [0]*/ A_Dialog_Takeru_General[1]  = "*Puts down Umbrella* ";        
        /*P 2.2 = [9]*/ A_Dialog_Takeru_General[2]  = "»Oh, hello, Takeru. You're quite early today?« ";        
        /*T 1.2 = [1]*/ A_Dialog_Takeru_General[3]  = "»Yes, there is a competition at the garden center today! There will be the prettiest hydrangeas around!« ";        
        /*P 1.1 = [0]*/ A_Dialog_Takeru_General[4]  = "»Sounds great! Did you submit any?« ";        
        /*T 1.5 = [4]*/ A_Dialog_Takeru_General[5]  = "»Um, well.. not really.« ";        
        /*P 1.4 = [3]*/ A_Dialog_Takeru_General[6]  = "»Why not?« ";        
        /*T 1.6 = [5]*/ A_Dialog_Takeru_General[7]  = "»Dunno... Mine are nice, but they don't measure up to those of professional gardeners.« ";       
        /*P 1.4 = [3]*/ A_Dialog_Takeru_General[8]  = "»Don't talk such nonsense! Next year you will take part in the competition.« ";        
        /*T 1.6 = [5]*/ A_Dialog_Takeru_General[9]  = "»Well... Let's see.« ";          
        /*P 1.4 = [3]*/ A_Dialog_Takeru_General[10] = "»Don't make that face. What will you have today?« ";         
        /*T 1.7 = [6]*/ A_Dialog_Takeru_General[11] = "»I’d like Tonbara. To go please.« ";        
        /*P 1.8 = [7]*/ A_Dialog_Takeru_General[12] = "»Sure.« ";         
        /*P 2.1 = [1]*/ A_Dialog_Takeru_General[13] = "*Making food* ";       

    }
    public void Dialog_TakeruCorrect() /* Dialogue || 1.Correct || */
    {
        //Takeru enters Restaurant
        //CharaCount=0 Index=0-10 DialogCount=1

        /*P 1.8 = [7]*/ A_Dialog_Takeru_Correct[0]  = "»Here you are.« ";
        /*T 1.7 = [6]*/ A_Dialog_Takeru_Correct[1]  = "»Thank you.« ";
        /*P 1.8 = [7]*/ A_Dialog_Takeru_Correct[2]  = "»Hey, how did your date go?« ";
        /*T 1.6 = [5]*/ A_Dialog_Takeru_Correct[3]  = "»Actually quite well. I think I just laid on too thick.« ";
        /*P 1.3 = [3]*/ A_Dialog_Takeru_Correct[4]  = "»You?« ";
        /*T 1.5 = [4]*/ A_Dialog_Takeru_Correct[5]  = "»I don't know... It went very well, first we went for ice cream, and then we walked through the park, but I don't think they shared my passion for flowers. Maybe I shouldn't have emphasized the whole time that I've never eaten a human...« ";
        /*P 1.3 = [2]*/ A_Dialog_Takeru_Correct[6]  = "»Oh, I'm sorry. I'm sure it'll be better next time. Concentrate on the beautiful hydrangeas today, they will surely distract you!« ";
        /*T 1.7 = [6]*/ A_Dialog_Takeru_Correct[7]  = "»Oh yes! That's right, I have to go! Thanks, I'll take photos for you!« ";
        /*P 1.8 = [7]*/ A_Dialog_Takeru_Correct[8]  = "»Have a nice day!« ";
        /*P Gone  */    A_Dialog_Takeru_Correct[9]  = "*Gives money and leaves, forgets the umbrella* ";
        /*P Gone  */    A_Dialog_Takeru_Correct[10] = "»Takeru! Your umbrella! Oh, he's already gone. Then I'll stow it away until he comes back.« ";

    }
    public void Dialog_TakeruWrong() /* Dialogue || 1.Wrong || */
    {
        //Takeru enters Restaurant
        //CharaCount=0 Index=0-4 DialogCount=3

        /*P 1.8 = [7]*/ A_Dialog_Takeru_Wrong[0] = "»Here you are.« ";
        /*T 1.7 = [6]*/ A_Dialog_Takeru_Wrong[1] = "»Thank you! Then I have to leave quickly! Have a great day.« ";
        /*P 1.8 = [7]*/ A_Dialog_Takeru_Wrong[2] = "»You too!« ";
        /*T LEAVES  */  A_Dialog_Takeru_Wrong[3] = "*Gives money and leaves, forget the umbrella*  ";
        /*P Gone  */    A_Dialog_Takeru_Wrong[4] = "»Takeru! Your umbrella! Oh, he's already gone. Then I'll stow it away until he comes back.« ";





        //FINDING CALLS


    }


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Mamoru

    public void Dialog_MamoruGeneral() /* Dialog || 2 || */
    {
        //Takeru enters Restaurant
        //CharaCount=1 Index=0-13 DialogCount=0

        /*M 2.3 = [6]*/ A_Dialog_Mamoru_General[0] = "»Hello, my favorite chef!« ";
        /*P 2.3 = [6]*/ A_Dialog_Mamoru_General[1] = "»Don't let my colleagues hear that.« ";
        /*M 2.2 = [5]*/ A_Dialog_Mamoru_General[2] = "*Laughs* ";
        /*P 2.3 = [6]*/ A_Dialog_Mamoru_General[3] = "»Tell me, how are you?« ";
        /*M 1.2 = [1]*/ A_Dialog_Mamoru_General[4] = "»Oh, better than ever. Everything is just fine right now.« ";
        /*P 1.1 = [0]*/ A_Dialog_Mamoru_General[5] = "»I'm glad.« *hesitates* »Say, could you do me a favor?« ";
        /*M 1.1 = [0]*/ A_Dialog_Mamoru_General[6] = "»Of course! What is it?« ";
        /*P 1.1 = [0]*/ A_Dialog_Mamoru_General[7] = "»You remember the little Y?rei?« ";
        /*M 2.1 = [4]*/ A_Dialog_Mamoru_General[8] = "»Sure, how is she? Is she still there?« ";
        /*P 2.1 = [4]*/ A_Dialog_Mamoru_General[9] = "»Yes, and I tried to talk to her. She said she was afraid of something, but didn't say what. Can you find out for me? As a Baku, you can see people's concerns. Is that also possible with Y?rei?« ";
        /*M 2.1 = [4]*/ A_Dialog_Mamoru_General[10] = "»Hm… I don't know. But I can try it.« ";
        /*P 2.3 = [6]*/ A_Dialog_Mamoru_General[11] = "»Oh, thank you! Say, what ramen do you want? Then I can get it started.« ";
        /*M 2.3 = [6]*/ A_Dialog_Mamoru_General[12] = "»Oh, Kikaku please.« ";
        /*P 2.3 = [6]*/ A_Dialog_Mamoru_General[13] = "»Of course.« ";
        /*P 2.3 = [6]*/ A_Dialog_Mamoru_General[14] = "*Making food* ";

    }
    public void Dialog_MamoruCorrect() /* Dialog || 2.Correct || */
    {
        //Takeru enters Restaurant
        //CharaCount=1 Index=0-15 DialogCount=1

        /*p 1.1 = [0]*/ A_Dialog_Mamoru_Correct[0]  = "»Here, your ramen. Enjoy your meal.« ";
        /*m 1.3 = [2]*/ A_Dialog_Mamoru_Correct[1]  = "»And I have more good news too! The little one is afraid of water.« ";
        /*p 1.3 = [2]*/ A_Dialog_Mamoru_Correct[2]  = "»Water? Why?« ";
        /*m 2.1 = [4]*/ A_Dialog_Mamoru_Correct[3]  = "»Well, you'll have to ask her that yourself.« ";
        /*p 2.1 = [4]*/ A_Dialog_Mamoru_Correct[4]  = "»Thank you, Mamoru. Maybe I can help her somehow.« ";
        /*m 2.3 = [6]*/ A_Dialog_Mamoru_Correct[5]  = "»I am sure of that. You've got a knack for it.« ";
        /*p 2.3 = [6]*/ A_Dialog_Mamoru_Correct[6]  = "»How is it going with your Arashi?« ";
        /*m 2.2 = [5]*/ A_Dialog_Mamoru_Correct[7]  = "»I gave him my spare key now.« ";
        /*p 2.2 = [5]*/ A_Dialog_Mamoru_Correct[8]  = "»Uh, how romantic.« ";
        /*m 2.3 = [6]*/ A_Dialog_Mamoru_Correct[9]  = "»Not really, I have to buy everything twice. So now I have a toothbrush in every apartment.«";
        /*p 2.3 = [6]*/ A_Dialog_Mamoru_Correct[10] = "»Well, then you'll have to move in together.« ";
        /*m 2.1 = [4]*/ A_Dialog_Mamoru_Correct[11] = "»I don't know if we're ready for that yet... Even though we're actually always together.« ";
        /*p 1.2 = [1]*/ A_Dialog_Mamoru_Correct[12] = "»Oh, don't stress. You still have plenty of time.« ";
        /*m 1.2 = [1]*/ A_Dialog_Mamoru_Correct[13] = "»You're right. I'll go eat. Finding out a fear like that makes you hungry.« ";
        /*p 1.2 = [1]*/ A_Dialog_Mamoru_Correct[14] = "»Thank you again! Bon appétit!« ";
        /*m LEAVES   */ A_Dialog_Mamoru_Correct[15] = "*Gives money and sits down in the back* ";


    }
    public void Dialog_MamoruWrong() /* Dialog || 2.Wrong || */
    {
        //Takeru enters Restaurant
        //CharaCount=1 Index=0-7 DialogCount=2

        /*p 1.1 = [0]*/ A_Dialog_Mamoru_Wrong[0] = "»Here, your ramen. Enjoy your meal.« ";
        /*m 1.3 = [2]*/ A_Dialog_Mamoru_Wrong[1] = "»And I have more good news too! The little one is afraid of water.« ";
        /*p 1.3 = [2]*/ A_Dialog_Mamoru_Wrong[2] = "»Water? Why?« ";
        /*m 2.1 = [4]*/ A_Dialog_Mamoru_Wrong[3] = "»Well, you'll have to ask her that yourself.« ";
        /*p 2.1 = [4]*/ A_Dialog_Mamoru_Wrong[4] = "»Thank you, Mamoru. Maybe I can help her somehow.« ";
        /*m 2.3 = [5]*/ A_Dialog_Mamoru_Wrong[5] = "»I am sure of that. You've got a knack for it. I'll go sit in the back, finding out a fear like that makes you hungry« ";
        /*p 1.2 = [1]*/ A_Dialog_Mamoru_Wrong[6] = "»Thank you again! Bon appétit!« ";
        /*m LEAVES   */ A_Dialog_Mamoru_Wrong[7] = "*Gives money and sits down in the back* ";
    }


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // Nanami

    public void Dialog_NanamiGeneral() /* Dialog || 3. || */
    {
        //Takeru enters Restaurant
        //CharaCount=2 Index=0-12 DialogCount=0

        /*n 1.3 = [2]*/  A_Dialog_Nanami_General[0] = "*silently coming up to the counter* ";
        /*p 1.3 = [2]*/  A_Dialog_Nanami_General[1] = "»Oh hello. How can I help you?« ";
        /*n 1.4 = [3]*/  A_Dialog_Nanami_General[2] = "»I'm hungry.« ";
        /*p 2.3 = [8]*/  A_Dialog_Nanami_General[3] = "»Luckily, this is a restaurant. So, what would you like?« ";
        /*n 2.5 = [10]*/ A_Dialog_Nanami_General[4] = "»... I have no money.« ";
        /*p 2.6 = [11]*/ A_Dialog_Nanami_General[5] = "»Oh... take your pick anyway.« ";
        /*n 2.1 = [6]*/  A_Dialog_Nanami_General[6] = "*silence* ";
        /*p 2.1 = [6]*/  A_Dialog_Nanami_General[7] = "»On the house. Come on, what would you like?« ";
        /*n 1.4 = [3]*/  A_Dialog_Nanami_General[8] = "»What's delicious?« ";
        /*p 1.3 = [2]*/  A_Dialog_Nanami_General[9] = "»Hmm… well, my favorite is Tonbara, although that's a bit odd. Maybe you'd rather have the classic, the Kikaku.« ";
        /*n 1.6 = [5]*/  A_Dialog_Nanami_General[10] = "»The one you like.« ";
        /*p 1.3 = [2]*/  A_Dialog_Nanami_General[11] = "»Okay, coming right away.« ";
        /*p 1.3 = [2]*/  A_Dialog_Nanami_General[12] = "*Making food*  ";

    }
    public void Dialog_NanamiCorrect() /* Dialog || 3.Correct || */
    {
        //Takeru enters Restaurant
        //CharaCount=2 Index=0-6 DialogCount=1

        /*p 1.3 = [2]*/  A_Dialog_Nanami_Correct[0] = "»Here you go. Enjoy your meal.« ";
        /*n 1.5 = [4]*/  A_Dialog_Nanami_Correct[1] = "»Thank you.« ";
        /*n 1.3 = [2]*/  A_Dialog_Nanami_Correct[2] = "*Silence* ";
        /*p 2.1 = [6]*/  A_Dialog_Nanami_Correct[3] = "»Nanami? Are you alright?« ";
        /*n 2.2 = [7]*/  A_Dialog_Nanami_Correct[4] = "»I... don't want to eat alone.« ";
        /*p 2.3 = [8]*/  A_Dialog_Nanami_Correct[5] = "»Hmm… I'll be done in ten minutes. Can you wait that long?« ";
        /*n 2.4 = [9]*/ A_Dialog_Nanami_Correct[6] = "»Hmm.« *nods*« ";
        /*n LEAVES   */  A_Dialog_Nanami_Correct[7] = "*Leaves the counter*  ";

    }
    public void Dialog_NanamiWrong() /* Dialog || 3.Wrong || */
    {
        //Takeru enters Restaurant
        //CharaCount=2 Index=0-1 DialogCount=2

        /*p 1.3 = [2]*/ A_Dialog_Nanami_Wrong[0] = "»Here you go.« ";
        /*n 1.5 = [4]*/ A_Dialog_Nanami_Wrong[1] = "»Thanks.« ";
        /*n LEAVES   */ A_Dialog_Nanami_Wrong[2] = "*Hesitates, then leaves* ";

    }




    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    //FINDING CALLS




}
