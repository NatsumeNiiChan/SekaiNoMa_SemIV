using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationEvent_IngredientLayer : MonoBehaviour
{
    //Scripts
    [HideInInspector]
    public MouseRay S_MouseRay;



//START
    void Start()
    {
        //FindingScripts
        S_MouseRay = GameObject.Find("GameManager").GetComponent<MouseRay>();

    }

//UPDATE
    void Update()
    {
        
    }

//FUNCTIONS

    public void AnimationEndLayerSwitch()
    {
        for (int i = 0; i < S_MouseRay.A_IngredientList.Length; i++)
        {
            S_MouseRay.A_IngredientSprite[i].sortingLayerName = "Ingredients_In";

        }

    }





    //FINDING CALLS


}
