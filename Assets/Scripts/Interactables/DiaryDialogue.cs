using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiaryDialogue : MonoBehaviour
{
    public GameObject textBox;
    public Text entryText;
    
    public string[] entryLines;
    public int currentLine;

    public Animator anim;
    

    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
        
        entryText.text = entryLines[currentLine];

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            
            currentLine++;
            anim.SetTrigger("Turned");
            
        }

        if (currentLine >= 3)
        {
            currentLine = 0;
        }
    }
}
