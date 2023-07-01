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

        /*2.1 = [8]*/ A_Dialog_Takeru_General[0]  = "»Hey!« ";  
        /*1.1 = [0]*/ A_Dialog_Takeru_General[1]  = "»*Legt Regenschirm ab*« ";        
        /*2.2 = [9]*/ A_Dialog_Takeru_General[2]  = "»Oh, hallo Takeru. Heute schon so früh da?« ";        
        /*1.2 = [1]*/ A_Dialog_Takeru_General[3]  = "»Ja, im Gartencenter findet heute ein Wettbewerb statt! Sie schauen sich die schönsten Hortensien dieser Gegend an!« ";        
        /*1.1 = [0]*/ A_Dialog_Takeru_General[4]  = "»Wie toll! Hast du auch welche eingereicht?« ";        
        /*1.5 = [4]*/ A_Dialog_Takeru_General[5]  = "»Ähm, also, naja, nicht so wirklich.« ";        
        /*1.4 = [3]*/ A_Dialog_Takeru_General[6]  = "»Warum denn nicht?« ";        
        /*1.6 = [5]*/ A_Dialog_Takeru_General[7]  = "»Weiß nicht… Meine sind ja ganz schön, aber sie können nicht mit denen von Profigärtnern mithalten.« ";       
        /*1.4 = [3]*/ A_Dialog_Takeru_General[8]  = "»Red nicht so einen Unsinn! Nächstes Jahr nimmst du an dem Wettbewerb teil.« ";        
        /*1.6 = [5]*/ A_Dialog_Takeru_General[9]  = "»Naja… Mal sehen.« ";          
        /*1.4 = [3]*/ A_Dialog_Takeru_General[10] = "»Mach nicht so ein Gesicht. Sag, was ich dir heute machen?« ";         
        /*1.7 = [6]*/ A_Dialog_Takeru_General[11] = "»Einmal Tonbara. Und bitte zum Mitnehmen.« ";        
        /*1.8 = [7]*/ A_Dialog_Takeru_General[12] = "»Gerne.« ";         
        /*2.1 = [1]*/ A_Dialog_Takeru_General[13] = "*Essen machen* ";       

    }
    public void Dialog_TakeruCorrect() /* Dialogue || 1.Correct || */
    {
        //Takeru enters Restaurant
        //CharaCount=0 Index=0-10 DialogCount=1

        /*1.8 = [7]*/ A_Dialog_Takeru_Correct[0]  = "»Hier, bitte sehr.« ";
        /*1.7 = [6]*/ A_Dialog_Takeru_Correct[1]  = "»Danke« ";
        /*1.8 = [7]*/ A_Dialog_Takeru_Correct[2]  = "»Wie ist dein Date eigentlich gelaufen?« ";
        /*1.6 = [5]*/ A_Dialog_Takeru_Correct[3]  = "»Eigentlich ganz gut. Ich glaub’, ich hab nur zu viel aufgetragen.« ";
        /*1.3 = [3]*/ A_Dialog_Takeru_Correct[4]  = "»Du?« ";
        /*1.5 = [4]*/ A_Dialog_Takeru_Correct[5]  = "»Ich weiß auch nicht. Es lief sehr gut, erst waren wir Eis essen und sind dann durch den Park spaziert, aber ich glaube er/sie hat meine Leidenschaft für Blumen nicht geteilt. Vielleicht hätte ich auch nicht die ganze Zeit betonen sollen, dass ich noch nie einen Menschen gefressen habe…« ";
        /*1.3 = [2]*/ A_Dialog_Takeru_Correct[6]  = "»Oh, das tut mir leid. Das nächste Mal läuft es sicher besser. Konzentriere dich heute ganz auf die wunderschönen Hortensien, das lenkt dich sicher ab!« ";
        /*1.7 = [6]*/ A_Dialog_Takeru_Correct[7]  = "»Oh ja! Stimmt, ich muss los! Danke, ich mach’ Fotos für dich!« ";
        /*1.8 = [7]*/ A_Dialog_Takeru_Correct[8]  = "»Schönen Tag noch!« ";
        /*Gone  */    A_Dialog_Takeru_Correct[9]  = "*Gibt Geld und geht, vergisst den Regenschirm* ";
        /*Gone  */    A_Dialog_Takeru_Correct[10] = "»Takeru! Dein Regenschirm! Oh, er ist schon weg. Dann werd’ ich ihn verstauen, bis er mal wieder da ist.« ";

    }
    public void Dialog_TakeruWrong() /* Dialogue || 1.Wrong || */
    {
        //Takeru enters Restaurant
        //CharaCount=0 Index=0-4 DialogCount=3

        /*1.8 = [7]*/ A_Dialog_Takeru_Wrong[0] = "»Hier, bitte schön.« ";
        /*1.7 = [6]*/ A_Dialog_Takeru_Wrong[1] = "»Danke! Ich muss dann auch schnell los! Hab noch einen tollen Tag.« ";
        /*1.8 = [7]*/ A_Dialog_Takeru_Wrong[2] = "»Du auch!« ";
        /*LEAVES  */  A_Dialog_Takeru_Wrong[3] = "*Gibt Geld und geht, vergisst den Regenschirm*  ";
        /*Gone  */    A_Dialog_Takeru_Wrong[4] = "»Takeru! Dein Regenschirm! Oh, er ist schon weg. Dann werd’ ich ihn verstauen, bis er mal wieder da ist.« ";





        //FINDING CALLS


    }


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Mamoru

    public void Dialog_MamoruGeneral() /* Dialog || 2 || */
    {
        //Takeru enters Restaurant
        //CharaCount=1 Index=0-13 DialogCount=0

        /*2.3 = [6]*/ A_Dialog_Mamoru_General[0] = "»Hallo, mein Lieblingskoch!« ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_General[1] = "»Sag das besser nicht zu meinen Kollegen.« ";
        /*2.2 = [5]*/ A_Dialog_Mamoru_General[2] = "*lacht* ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_General[3] = "»Sag, wie geht es dir?« ";
        /*1.2 = [1]*/ A_Dialog_Mamoru_General[4] = "»Hach, so gut wie noch nie. Gerade ist alles einfach prima.« ";
        /*1.1 = [0]*/ A_Dialog_Mamoru_General[5] = "»Das freut mich.« *zögert* »Sag, kannst du mir einen Gefallen tun?« ";
        /*1.1 = [0]*/ A_Dialog_Mamoru_General[6] = "»Natürlich, was denn?« ";
        /*1.1 = [0]*/ A_Dialog_Mamoru_General[7] = "»Du erinnerst dich an die kleine Yurei?« ";
        /*2.1 = [4]*/ A_Dialog_Mamoru_General[8] = "»Klar, wie geht es ihr? Ist sie etwa immer noch da?« ";
        /*2.1 = [4]*/ A_Dialog_Mamoru_General[9] = "»Ja, und ich habe versucht, mit ihr zu reden. Sie hat gemeint, sie habe vor etwas Angst, aber hat nicht gesagt wovor. Kannst du es für mich herausfinden? Als Baku kannst du doch die Sorgen der Menschen sehen. Geht das auch mit Yurei?« ";
        /*2.1 = [4]*/ A_Dialog_Mamoru_General[10] = "»Hm… Weiß nicht. Probieren kann ich es aber.« ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_General[11] = "»Oh danke! Sag, welche Ramen willst du? Dann kann ich schonmal anfangen.« ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_General[12] = "»Ach, Kikaku bitte.« ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_General[13] = "»Klar doch.« ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_General[14] = "*Essen machen* ";

    }
    public void Dialog_MamoruCorrect() /* Dialog || 2.Correct || */
    {
        //Takeru enters Restaurant
        //CharaCount=1 Index=0-15 DialogCount=1

        /*1.1 = [0]*/ A_Dialog_Mamoru_Correct[0]  = "»Hier, dein Ramen. Lass es dir schmecken.« ";
        /*1.3 = [2]*/ A_Dialog_Mamoru_Correct[1]  = "»Und ich hab auch noch mehr gute Neuigkeiten! Die Kleine hat Angst vor Wasser.« ";
        /*1.3 = [2]*/ A_Dialog_Mamoru_Correct[2]  = "»Wasser? Warum?« ";
        /*2.1 = [4]*/ A_Dialog_Mamoru_Correct[3]  = "»Tja, das musst du sie selbst fragen.« ";
        /*2.1 = [4]*/ A_Dialog_Mamoru_Correct[4]  = "»Danke, Mamoru. Vielleicht kann ich ihr ja irgendwie helfen.« ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_Correct[5]  = "»Da bin ich mir sicher. Du hast ein Händchen dafür.« ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_Correct[6]  = "»Wie läuft es mit deinem Partner eigentlich?« ";
        /*2.2 = [5]*/ A_Dialog_Mamoru_Correct[7]  = "»Ich hab ihm jetzt auch meinen Zweitschlüssel gegeben.« ";
        /*2.2 = [5]*/ A_Dialog_Mamoru_Correct[8]  = "»Uh, wie romantisch.« ";
        /*2.3 = [6]*/ A_Dialog_Mamoru_Correct[9]  = "»Eigentlich gar nicht, ich muss alles doppelt kaufen. So hab ich jetzt in jeder Wohnung eine Zahnbürste.«";
        /*2.3 = [6]*/ A_Dialog_Mamoru_Correct[10] = "»Tja, dann müsst ihr wohl zusammenziehen.« ";
        /*2.1 = [4]*/ A_Dialog_Mamoru_Correct[11] = "»Ich weiß nicht, ob wir dafür schon bereit sind… Auch wenn wir eigentlich immer beieinander sind.« ";
        /*1.2 = [1]*/ A_Dialog_Mamoru_Correct[12] = "»Ach, stresst euch nicht. Ihr habt noch viel Zeit.« ";
        /*1.2 = [1]*/ A_Dialog_Mamoru_Correct[13] = "»Du hast recht. Ich werd’ mal essen gehen. So eine Angst herausfinden, macht hungrig.« ";
        /*1.2 = [1]*/ A_Dialog_Mamoru_Correct[14] = "»Danke nochmal! Guten Appetit!« ";
        /*LEAVES   */ A_Dialog_Mamoru_Correct[15] = "*Gibt Geld und setzt sich hinter* ";


    }
    public void Dialog_MamoruWrong() /* Dialog || 2.Wrong || */
    {
        //Takeru enters Restaurant
        //CharaCount=1 Index=0-7 DialogCount=2

        /*1.1 = [0]*/ A_Dialog_Mamoru_Wrong[0] = "»Hier, dein Ramen. Lass es dir schmecken.« ";
        /*1.3 = [2]*/ A_Dialog_Mamoru_Wrong[1] = "»Und ich hab auch noch mehr gute Neuigkeiten! Die Kleine hat Angst vor Wasser.« ";
        /*1.3 = [2]*/ A_Dialog_Mamoru_Wrong[2] = "»Wasser? Warum?« ";
        /*2.1 = [4]*/ A_Dialog_Mamoru_Wrong[3] = "»Tja, das musst du sie selbst fragen.« ";
        /*2.1 = [4]*/ A_Dialog_Mamoru_Wrong[4] = "»Danke, Mamoru. Vielleicht kann ich ihr ja irgendwie helfen.« ";
        /*2.3 = [5]*/ A_Dialog_Mamoru_Wrong[5] = "»Da bin ich mir sicher. Du hast ein Händchen dafür. Ich setzte mich mal hinter, so eine Angst herausfinden macht hungrig.« ";
        /*1.2 = [1]*/ A_Dialog_Mamoru_Wrong[6] = "»Danke nochmal! Guten Appetit!« ";
        /*LEAVES   */ A_Dialog_Mamoru_Wrong[7] = "*Gibt Geld und setzt sich hinter* ";
    }


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // Nanami

    public void Dialog_NanamiGeneral() /* Dialog || 3. || */
    {
        //Takeru enters Restaurant
        //CharaCount=2 Index=0-12 DialogCount=0

        /*1.3 = [2]*/  A_Dialog_Nanami_General[0] = "*Kommt still zur Theke* ";
        /*1.3 = [2]*/  A_Dialog_Nanami_General[1] = "»Oh, hallo. Wie kann ich dir helfen?« ";
        /*1.4 = [3]*/  A_Dialog_Nanami_General[2] = "»Ich hab Hunger.« ";
        /*2.3 = [8]*/  A_Dialog_Nanami_General[3] = "»Glücklicherweise ist das hier ein Restaurant. Also, was willst du?« ";
        /*2.5 = [10]*/ A_Dialog_Nanami_General[4] = "»… Ich hab kein Geld.« ";
        /*2.6 = [11]*/ A_Dialog_Nanami_General[5] = "»Oh… Such dir trotzdem was aus« ";
        /*2.1 = [6]*/  A_Dialog_Nanami_General[6] = "*Stille* ";
        /*2.1 = [6]*/  A_Dialog_Nanami_General[7] = "»Geht aufs Haus. Komm, worauf hast du Lust?« ";
        /*1.4 = [3]*/  A_Dialog_Nanami_General[8] = "»Was ist denn lecker?« ";
        /*1.3 = [2]*/  A_Dialog_Nanami_General[9] = "»Hm… Also mein Favorit ist Tonbara, wobei das ein bisschen eigen ist. Vielleicht willst du lieber den Klassiker, die Kikaku.« ";
        /*1.6 = [5]*/  A_Dialog_Nanami_General[10] = "»Das, was du magst.« ";
        /*1.3 = [2]*/  A_Dialog_Nanami_General[11] = "»Okay, kommt sofort.« ";
        /*1.3 = [2]*/  A_Dialog_Nanami_General[12] = "*Essen machen*  ";

    }
    public void Dialog_NanamiCorrect() /* Dialog || 3.Correct || */
    {
        //Takeru enters Restaurant
        //CharaCount=2 Index=0-6 DialogCount=1

        /*1.3 = [2]*/  A_Dialog_Nanami_Correct[0] = "»Hier, bitteschön. Lass es dir schmecken.« ";
        /*1.5 = [4]*/  A_Dialog_Nanami_Correct[1] = "»Danke.« ";
        /*1.3 = [2]*/  A_Dialog_Nanami_Correct[2] = "*Stille* ";
        /*2.1 = [6]*/  A_Dialog_Nanami_Correct[3] = "»Nanami? Alles in Ordnung?« ";
        /*2.2 = [7]*/  A_Dialog_Nanami_Correct[4] = "»Ich… Möchte nicht alleine essen.« ";
        /*2.3 = [8]*/  A_Dialog_Nanami_Correct[5] = "»Hm… Ich hab in zehn Minuten Schluss. Kannst du so lange warten?« ";
        /*2.4 = [9]*/ A_Dialog_Nanami_Correct[6] = "»Hmh.« ";
        /*LEAVES   */  A_Dialog_Nanami_Correct[7] = "*Geht*  ";

    }
    public void Dialog_NanamiWrong() /* Dialog || 3.Wrong || */
    {
        //Takeru enters Restaurant
        //CharaCount=2 Index=0-1 DialogCount=2

        /*1.3 = [2]*/ A_Dialog_Nanami_Wrong[0] = "»Hier bitte.« ";
        /*1.5 = [4]*/ A_Dialog_Nanami_Wrong[1] = "»Danke.« ";
        /*LEAVES   */ A_Dialog_Nanami_Wrong[2] = "*zögert und geht* ";

    }




    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    //FINDING CALLS




}
