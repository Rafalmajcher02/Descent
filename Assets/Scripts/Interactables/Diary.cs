using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;

public class Diary : MonoBehaviour
{
    public GameObject diaryCanvas;
    public bool diaryOpen;
    public bool inZone;

    void Update()
    {
       
        //Check whether the diary is open/closed and activate if needed
        if (inZone && !diaryOpen && (Input.GetKeyDown(KeyCode.E)))
        {
            diaryCanvas.SetActive(true);
            diaryOpen = true;  
        }
        else if (diaryOpen && (Input.GetKeyDown(KeyCode.E)))
        {
            diaryCanvas.SetActive(false);
            diaryOpen = false;
        }



      
    }

    void OnTriggerEnter2D(Collider2D other)
    {
       inZone = true;  
    }

    void OnTriggerExit2D(Collider2D other)
    {
        inZone = false;
    }

   


}
