
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class LoadScreenHints : MonoBehaviour
{
    public Text text;
    public string[] texts;
    

    // Start is called before the first frame update
    void Start()
    {
        text.text = texts[Random.Range(0, texts.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
