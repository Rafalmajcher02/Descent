using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DiaryAnimation : MonoBehaviour
{

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetTrigger("Turned");
        }
    }
}
