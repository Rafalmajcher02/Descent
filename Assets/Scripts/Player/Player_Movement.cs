using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : Rigid2D
{
    private const bool V = false;
    private const bool V1 = true;

    //Dragins
    [Header("Scripts and Components")]
    [Tooltip("Player Statistics Script needed.")]
    public Player_Statistics PS;
    [Tooltip("Drag in Game Object from the scene that has Temp_Boss_ScriptLoader (Possibly 'Boss')")]
    public Temp_Boss_ScriptLoader tbs;
    [Tooltip("AudioSource from player component. Should self reference, in case of error please drag it in.")]
    public AudioSource audioSource;


    //Player Statistics Variables
    [Header("Player Statistics")]
    private float MovementSpeed;
    private float JumpForce;
    private float playerMass;
    private float moveHorizontal;

    [Header("Animations")]
    public SpriteRenderer playerSprite;
    public Animator animator;
    public bool walking;
    public bool attacking;

    [Header("Audio")]
    //Audio clips
    public AudioClip walkSound;


    //Jump Check
    [Header("Bools")]
    private bool CanJump;
    public bool jumping;
    private string layerCheck = "Terrein";
    public bool isRight;


    //Boss Health Damager
    [Header("Testing Variables")]
    [Tooltip("Currently: If you press 'K' you deal this variable of damage to the boss.")]
    public float bossHealthDamage;
    private float bossCurrentHealth;



    public void Start()
    {
        //Getting audio source, this should prevent having to drag it in everytime
        audioSource = GetComponent<AudioSource>();
        PS = GetComponent<Player_Statistics>();

        //---Getting Variables from Player Statistics Script
        MovementSpeed = PS.moveSpeed;
        JumpForce = PS.jumpForce;
        playerMass = PS.playerMass;
        bossHealthDamage = PS.attackDamage;
    }

    
    public void Update()
    {
        //-----MOVEMENT-----
        moveHorizontal = Input.GetAxisRaw("Horizontal");
        movement();

        //-----VARIABLE UPDATES-----
        MovementSpeed = PS.moveSpeed;
        JumpForce = PS.jumpForce;
        playerMass = PS.playerMass;
        rigid2D.mass = playerMass;

        //-----ANIMATIONS-----
        animator.SetBool("Walking", walking);
        animator.SetBool("Jumping", jumping);
        animator.SetBool("Attacking", attacking);
    }

    private void movement()
    {       
        //P1: Using axis to allow for controlers to be pluged in
        if (moveHorizontal > 0.1f || moveHorizontal < -0.1f)
        {
            //Moves the player
            rigid2D.AddForce(new Vector2(moveHorizontal * MovementSpeed, 0f), ForceMode2D.Impulse);
            //Animations
            walking = V1;
            //Audio
            audioSource.clip = walkSound;
            audioSource.Play();
            
        }
        //Animations
        if (rigid2D.velocity.x == 0)
        {
            walking = V;
        }

        //P2: Same here just with input system for jump instaed of axis
        if (Input.GetButtonDown("Jumping") && CanJump)
        {
            //Jumps
            rigid2D.AddForce(transform.up * JumpForce, ForceMode2D.Impulse);
            //Ground Check
            CanJump = V;
            //Animations
            jumping = V1;
        }

        //Check which direction player is facing + flip sprite if needed
        if (moveHorizontal < -0.1f)
        {
            playerSprite.flipX = V1;
            isRight = V;
        }
        if (moveHorizontal > 0.1f)
        {
            playerSprite.flipX = V;
            isRight = V1;
        }
        //ANIMATIONS
        if (Input.GetKeyDown(KeyCode.L))
        {
            attacking = V1;
        }    
    }

  
    //This method deals damage to boss
    public void Damager()
    {
        bossCurrentHealth = tbs.bossHealth;
        bossCurrentHealth -= bossHealthDamage;
        tbs.bossHealth = bossCurrentHealth;
    }

    /// <summary>
    /// This is the in the way so that everytime the trigger on the player is left, method will prevent player from jumping again but
    /// TriggerStay allows to make sure the player landing is never skipped
    /// </summary>
    /// <param name="collision"></param>
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            CanJump = V1;
            jumping = V;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            CanJump = V;
            jumping = V1;
        }
    } 
}
