using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class S_BossAttack : MonoBehaviour
{
    public PlayerHealth ph;

    private bool attackDeleyed = true;

    private float attackDelay = 1.0f;

    public float bossDamage { get; set; }

    private void Awake()
    {
        bossDamage = 10.0f;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (attackDeleyed)
            {
                CloseAttack();
            }
        }
    }
    /// <summary>
    /// attackDeleyed allows to stop boss from attacking for duration of coroutine, which allows to stop boss attack spam
    /// </summary>
    private void CloseAttack()
    {
        StartCoroutine(AttackAfterDeley());
        ph.SendDamage(bossDamage); //Calls method from PlayerHealth
        attackDeleyed = false;
    }
    private IEnumerator AttackAfterDeley() //Allows for deley between shots in full auto mode
    {
        yield return new WaitForSeconds(attackDelay);
        attackDeleyed = true;
    }
}
