using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Load : MonoBehaviour
{
    public bool inZone;

    void Update()
    {
        if (inZone && (Input.GetKeyDown(KeyCode.E)))
        {
            SceneManager.LoadScene("TheLevel1");
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
