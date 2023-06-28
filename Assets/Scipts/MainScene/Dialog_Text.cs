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



    //Dialogue Texts
    [HideInInspector] public string[] A_Dialog_Takeru_General;
    [HideInInspector] public string[] A_Dialog_Takeru_Correct = new string[11];
    [HideInInspector] public string[] A_Dialog_Takeru_Wrong;

    [HideInInspector] public string[] A_Dialog_Mamoru_General;
    [HideInInspector] public string[] A_Dialog_Mamoru_Correct;
    [HideInInspector] public string[] A_Dialog_Mamoru_Wrong;

    [HideInInspector] public string[] A_Dialog_Nanami_General;
    [HideInInspector] public string[] A_Dialog_Nanami_Correct;
    [HideInInspector] public string[] A_Dialog_Nanami_Wrong;


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    //START
    void Start()
    {
        //S_MouseRay = GameObject.Find("GameManager").GetComponent<MouseRay>();
        //Dialogue_TakeruGeneral();

        //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        //Takeru
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
    //Takeru

    public void Dialog_TakeruGeneral() /* Dialogue || 1 || */
    {
        Debug.Log(A_Dialog_Takeru_General.Length);

        //Takeru enters Restaurant
        A_Dialog_Takeru_General[0] = "»Hey!« ";
        A_Dialog_Takeru_General[1] = "»*Legt Regenschirm ab*« ";
        A_Dialog_Takeru_General[2] = "»Oh, hallo Takeru. Heute schon so früh da?« ";
        A_Dialog_Takeru_General[3] = "»Ja, im Gartencenter findet heute ein Wettbewerb statt! Sie schauen sich die schönsten Hortensien dieser Gegend an!« ";
        A_Dialog_Takeru_General[4] = "»Wie toll! Hast du auch welche eingereicht?« ";
        A_Dialog_Takeru_General[5] = "»Ähm, also, naja, nicht so wirklich.« ";
        A_Dialog_Takeru_General[6] = "»Warum denn nicht?« ";
        A_Dialog_Takeru_General[7] = "»Weiß nicht… Meine sind ja ganz schön, aber sie können nicht mit denen von Profigärtnern mithalten.« ";
        A_Dialog_Takeru_General[8] = "»Red nicht so einen Unsinn! Nächstes Jahr nimmst du an dem Wettbewerb teil.« ";
        A_Dialog_Takeru_General[9] = "»Naja… Mal sehen.« ";
        A_Dialog_Takeru_General[10] = "»Mach nicht so ein Gesicht. Sag, was ich dir heute machen?« ";
        A_Dialog_Takeru_General[11] = "»Einmal Tonbara. Und bitte zum Mitnehmen.« ";
        A_Dialog_Takeru_General[12] = "»Gerne.« ";
        A_Dialog_Takeru_General[13] = "*Essen machen* ";

    }
    public void Dialog_TakeruCorrect() /* Dialogue || 1.Correct || */
    {
        //Takeru enters Restaurant
        A_Dialog_Takeru_Correct[0] = "»Hier, bitte sehr.« ";
        A_Dialog_Takeru_Correct[1] = "»Danke« ";
        A_Dialog_Takeru_Correct[2] = "»Wie ist dein Date eigentlich gelaufen?« ";
        A_Dialog_Takeru_Correct[3] = "»Eigentlich ganz gut. Ich glaub’, ich hab nur zu viel aufgetragen.« ";
        A_Dialog_Takeru_Correct[4] = "»Du?« ";
        A_Dialog_Takeru_Correct[5] = "»Ich weiß auch nicht. Es lief sehr gut, erst waren wir Eis essen und sind dann durch den Park spaziert, aber ich glaube er/sie hat meine Leidenschaft für Blumen nicht geteilt. Vielleicht hätte ich auch nicht die ganze Zeit betonen sollen, dass ich noch nie einen Menschen gefressen habe…« ";
        A_Dialog_Takeru_Correct[6] = "»Oh, das tut mir leid. Das nächste Mal läuft es sicher besser. Konzentriere dich heute ganz auf die wunderschönen Hortensien, das lenkt dich sicher ab!« ";
        A_Dialog_Takeru_Correct[7] = "»Oh ja! Stimmt, ich muss los! Danke, ich mach’ Fotos für dich!« ";
        A_Dialog_Takeru_Correct[8] = "»Schönen Tag noch!« ";
        A_Dialog_Takeru_Correct[9] = "*Gibt Geld und geht, vergisst den Regenschirm* ";
        A_Dialog_Takeru_Correct[10] = "»Takeru! Dein Regenschirm! Oh, er ist schon weg. Dann werd’ ich ihn verstauen, bis er mal wieder da ist.« ";

    }
    public void Dialog_TakeruWrong() /* Dialogue || 1.Wrong || */
    {
        //Takeru enters Restaurant
        A_Dialog_Takeru_Wrong[0] = "»Hier, bitte schön.« ";
        A_Dialog_Takeru_Wrong[1] = "»Danke! Ich muss dann auch schnell los! Hab noch einen tollen Tag.« ";
        A_Dialog_Takeru_Wrong[2] = "»Du auch!« ";
        A_Dialog_Takeru_Wrong[3] = "*Gibt Geld und geht, vergisst den Regenschirm*  ";
        A_Dialog_Takeru_Wrong[4] = "»Takeru! Dein Regenschirm! Oh, er ist schon weg. Dann werd’ ich ihn verstauen, bis er mal wieder da ist.« ";





        //FINDING CALLS


    }


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    //Mamoru

    public void Dialog_MamoruGeneral() /* Dialog || 2 || */
    {
        //Takeru enters Restaurant
        A_Dialog_Mamoru_General[0] = "»Hallo, mein Lieblingskoch!« ";
        A_Dialog_Mamoru_General[1] = "»Sag das besser nicht zu meinen Kollegen.« ";
        A_Dialog_Mamoru_General[2] = "*lacht* ";
        A_Dialog_Mamoru_General[3] = "»Sag, wie geht es dir?« ";
        A_Dialog_Mamoru_General[4] = "»Hach, so gut wie noch nie. Gerade ist alles einfach prima.« ";
        A_Dialog_Mamoru_General[5] = "»Das freut mich.« *zögert* »Sag, kannst du mir einen Gefallen tun?« ";
        A_Dialog_Mamoru_General[6] = "»Natürlich, was denn?« ";
        A_Dialog_Mamoru_General[7] = "»Du erinnerst dich an die kleine Y?rei?« ";
        A_Dialog_Mamoru_General[8] = "»Klar, wie geht es ihr? Ist sie etwa immer noch da?« ";
        A_Dialog_Mamoru_General[9] = "»Ja, und ich habe versucht, mit ihr zu reden. Sie hat gemeint, sie habe vor etwas Angst, aber hat nicht gesagt wovor. Kannst du es für mich herausfinden? Als Baku kannst du doch die Sorgen der Menschen sehen. Geht das auch mit Y?rei?« ";
        A_Dialog_Mamoru_General[10] = "»Hm… Weiß nicht. Probieren kann ich es aber.« ";
        A_Dialog_Mamoru_General[11] = "»Oh danke! Sag, welche Ramen willst du? Dann kann ich schonmal anfangen.« ";
        A_Dialog_Mamoru_General[12] = "»Ach, Kikaku bitte.« ";
        A_Dialog_Mamoru_General[13] = "»Klar doch.« ";
        A_Dialog_Mamoru_General[13] = "*Essen machen* ";

    }
    public void Dialog_MamoruCorrect() /* Dialog || 2.Correct || */
    {
        //Takeru enters Restaurant
        A_Dialog_Mamoru_Correct[0] = "»Hier, dein Ramen. Lass es dir schmecken.« ";
        A_Dialog_Mamoru_Correct[1] = "»Und ich hab auch noch mehr gute Neuigkeiten! Die Kleine hat Angst vor Wasser.« ";
        A_Dialog_Mamoru_Correct[2] = "»Wasser? Warum?« ";
        A_Dialog_Mamoru_Correct[3] = "»Tja, das musst du sie selbst fragen.« ";
        A_Dialog_Mamoru_Correct[4] = "»Danke, Mamoru. Vielleicht kann ich ihr ja irgendwie helfen.« ";
        A_Dialog_Mamoru_Correct[5] = "»Da bin ich mir sicher. Du hast ein Händchen dafür.« ";
        A_Dialog_Mamoru_Correct[6] = "»Wie läuft es mit deinem Partner eigentlich?« ";
        A_Dialog_Mamoru_Correct[7] = "»Ich hab ihm jetzt auch meinen Zweitschlüssel gegeben.« ";
        A_Dialog_Mamoru_Correct[8] = "»Uh, wie romantisch.« ";
        A_Dialog_Mamoru_Correct[9] = "»Eigentlich gar nicht, ich muss alles doppelt kaufen. So hab ich jetzt in jeder Wohnung eine Zahnbürste.«";
        A_Dialog_Mamoru_Correct[10] = "»Tja, dann müsst ihr wohl zusammenziehen.« ";
        A_Dialog_Mamoru_Correct[11] = "»Ich weiß nicht, ob wir dafür schon bereit sind… Auch wenn wir eigentlich immer beieinander sind.« ";
        A_Dialog_Mamoru_Correct[12] = "»Ach, stresst euch nicht. Ihr habt noch viel Zeit.« ";
        A_Dialog_Mamoru_Correct[13] = "»Du hast recht. Ich werd’ mal essen gehen. So eine Angst herausfinden, macht hungrig.« ";
        A_Dialog_Mamoru_Correct[14] = "»Danke nochmal! Guten Appetit!« ";
        A_Dialog_Mamoru_Correct[15] = "*Gibt Geld und setzt sich hinter* ";


    }
    public void Dialog_MamoruWrong() /* Dialog || 2.Wrong || */
    {
        //Takeru enters Restaurant
        A_Dialog_Mamoru_Wrong[0] = "»Hier, dein Ramen. Lass es dir schmecken.« ";
        A_Dialog_Mamoru_Wrong[1] = "»Und ich hab auch noch mehr gute Neuigkeiten! Die Kleine hat Angst vor Wasser.« ";
        A_Dialog_Mamoru_Wrong[2] = "»Wasser? Warum?« ";
        A_Dialog_Mamoru_Wrong[3] = "»Tja, das musst du sie selbst fragen.« ";
        A_Dialog_Mamoru_Wrong[4] = "»Danke, Mamoru. Vielleicht kann ich ihr ja irgendwie helfen.« ";
        A_Dialog_Mamoru_Wrong[5] = "»Da bin ich mir sicher. Du hast ein Händchen dafür. Ich setzte mich mal hinter, so eine Angst herausfinden macht hungrig.« ";
        A_Dialog_Mamoru_Wrong[6] = "»Danke nochmal! Guten Appetit!« ";
        A_Dialog_Mamoru_Wrong[7] = "*Gibt Geld und setzt sich hinter* ";
    }


    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    // Nanami

    public void Dialog_NanamiGeneral() /* Dialog || 3. || */
    {
        //Takeru enters Restaurant
        A_Dialog_Nanami_General[0] = "*kommt still zur Theke* ";
        A_Dialog_Nanami_General[1] = "»Oh, hallo. Wie kann ich dir helfen?« ";
        A_Dialog_Nanami_General[2] = "»Ich hab Hunger.« ";
        A_Dialog_Nanami_General[3] = "»Glücklicherweise ist das hier ein Restaurant. Also, was willst du?« ";
        A_Dialog_Nanami_General[4] = "»… Ich hab kein Geld.« ";
        A_Dialog_Nanami_General[5] = "»Oh… Such dir trotzdem was aus« ";
        A_Dialog_Nanami_General[6] = "*Stille* ";
        A_Dialog_Nanami_General[7] = "»Geht aufs Haus. Komm, worauf hast du Lust?« ";
        A_Dialog_Nanami_General[8] = "»Was ist denn lecker?« ";
        A_Dialog_Nanami_General[9] = "»Hm… Also mein Favorit ist Tonbara, wobei das ein bisschen eigen ist. Vielleicht willst du lieber den Klassiker, die -Rezeptname-.« ";
        A_Dialog_Nanami_General[10] = "»Das, was du magst.« ";
        A_Dialog_Nanami_General[11] = "»Okay, kommt sofort.« ";
        A_Dialog_Nanami_General[12] = "*Essen machen*  ";

    }
    public void Dialog_NanamiCorrect() /* Dialog || 3.Correct || */
    {
        //Takeru enters Restaurant
        A_Dialog_Nanami_Correct[0] = "»Hier, bitteschön. Lass es dir schmecken.« ";
        A_Dialog_Nanami_Correct[1] = "»Danke.« *Stille* ";
        A_Dialog_Nanami_Correct[2] = "»Nanami? Alles in Ordnung?« ";
        A_Dialog_Nanami_Correct[3] = "»Ich… Möchte nicht alleine essen.« ";
        A_Dialog_Nanami_Correct[4] = "»Hm… Ich hab in zehn Minuten Schluss. Kannst du so lange warten?« ";
        A_Dialog_Nanami_Correct[5] = "»Hmh.« ";
        A_Dialog_Nanami_Correct[6] = "*Geht*  ";

    }
    public void Dialog_NanamiWrong() /* Dialog || 3.Wrong || */
    {
        //Takeru enters Restaurant
        A_Dialog_Nanami_Wrong[0] = "»Hier bitte.« ";
        A_Dialog_Nanami_Wrong[1] = "»Danke.« *zögert und geht* ";

    }




    //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    //FINDING CALLS




}
