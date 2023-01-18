using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressAnyKeyTostart : MonoBehaviour
{
    //--------------------------------------------------------
    // Script to load a named scene when any key is pressed.
    //Intended to only be used to trigger the next scene from a splashscreen
    //Terry Greer 09/sept/2020
    //--------------------------------------------------------
    public string scenename;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.anyKey)
        {
            SceneManager.LoadScene(scenename);
        }
        
       
        /*
        //-------------------------------------------------------
        //Alternatively if you want to make it just the space key
        //-------------------------------------------------------
        if (Input.GetKeyDown("space"))
        {
            SceneManager.LoadScene(scenename);
        }
        */

    }



}
