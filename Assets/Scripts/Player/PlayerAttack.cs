using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public Animator animator;
    public Transform attackPoint;
    public float attackRange = 1f;
    public LayerMask enemyLayers;
    public int attackDamage = 30;
    public float attackRate = 2f;
    float nextAttackTime = 0f;

    void Update()
    {
        //Only lets the player attack twice a second
        if(Time.time >= nextAttackTime)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackRate;
            }
        }
    }

    void Attack()
    {
        //Play an attack animaton
        animator.SetTrigger("Attacking");
        //Detect enemies in range
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayers);
        //Damage them
        foreach(Collider2D enemy in hitEnemies)
        {
            Debug.Log("We hit " + enemy.name);
            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }

    void OnDrawGizmosSelected()
    {
        if (attackPoint == null)
        {
            return;
        }

        //Displays the area of attack
        Gizmos.DrawWireSphere(attackPoint.position, attackRange);
    }
}
