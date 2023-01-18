using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackArea : MonoBehaviour
{
    public Player_Movement pm;

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == ("Boss"))
        {
            pm.Damager();
        }
    }
}
