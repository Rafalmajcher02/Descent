using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int maxHealth = 100;
    int currentHealth;

    void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        //Damages the enemy by the damage amount determined by the player attack script
        currentHealth -= damage;

        //Used to display the enemy hurt animation
        //animator.SetTrigger("Hurt");

        //Causes the enemy to die when their health reaches 0
        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy Died!");

        //Plays death animation
        animator.SetBool("IsDead", true);

        //Disables the enemies hitbox
        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
    }
}
