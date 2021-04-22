using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Split : MonoBehaviour{

    public Camera cam1, cam2;

    private bool isHorizontalSplit;

    void Start(){
        
    }

    void Update(){

        if(SwitchScene.mode == "multi"){
            
            /* Horizontal split 
            cam1.rect = new Rect(0f, .5f, 1f, .5f);
            cam2.rect = new Rect(0f, 0f, 1f, .5f);
            */

            // Vertical split
            cam1.rect = new Rect(0f, 0f, .5f, 1f);
            cam2.rect = new Rect(.5f, 0f, .5f, 1f);
            

        }

        if(SwitchScene.mode == "solo"){
            cam1.rect = new Rect(0f, 0f, 1f, 1f);
            cam2.rect = new Rect(0f, 0f, 0f, 0f);
        }
    }



/*
    public void SwitchView(){
        isHorizontalSplit = !isHorizontalSplit;

        SetSplitScreen();
    }

    public void SinglePlayer(){
        cam1.rect = new Rect(0f, 0f, 1f, 1f);
        cam2.rect = new Rect(0f, 0f, 0f, 0f);
    }

    public void MultiPlayer(){
        SetSplitScreen();
    }

    public void SetSplitScreen(){
        if(isHorizontalSplit){

            cam1.rect = new Rect(0f, .5f, 1f, .5f);
            cam2.rect = new Rect(0f, 0f, 1f, .5f);

        } else{

            

        }
    }
    */
}

