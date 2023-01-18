using Microsoft.Win32;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject howToPlay;
    
    public bool active;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        



    }

    public void ShowImage()
    {
        howToPlay.gameObject.SetActive(true);
    }

}
