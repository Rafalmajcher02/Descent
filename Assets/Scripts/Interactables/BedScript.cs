using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BedScript : MonoBehaviour
{
    public bool inZone;

  

    // Update is called once per frame
    void Update()
    {
        if (inZone && (Input.GetKeyDown(KeyCode.E)))
        {
            Fungus.Flowchart.BroadcastFungusMessage("GoToSleep");
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
