using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float curHealth { set; get; }
    private float maxHealth = 100f;
    public Slider healthBar;
    public Player_Statistics ps;


    void Start()
    {
        curHealth = ps.playerHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = curHealth;
    }
    //Allows to update health if health was affected in any other way
    private void Update()
    {
        healthBar.value = curHealth;
    }

    //Damage Taking Method
    public void SendDamage(float damageValue)
    {
        curHealth -= damageValue;
        healthBar.value = curHealth;
        if (curHealth < 0)
        {
            curHealth = 0;
        }
    }
    //Healthing Method
    public void SendHeal(float healValue)
    {
        curHealth += healValue;
        healthBar.value = curHealth;
        if (curHealth > 100)
        {
            curHealth = 100;
        }
    }
}
