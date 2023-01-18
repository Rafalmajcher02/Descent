using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Statistics : MonoBehaviour
{

    [Header("Movement Settings")]
    [Range(0.01f, 100.0f)]
    public float moveSpeed = 0.1f;
    [Range(0.01f, 100.0f)]
    public float jumpForce = 14f;
    [Range(0.01f, 100.0f)]
    public float playerMass = 2.3f;
    [Range(0.01f, 50.0f)]
    public float attackDamage = 5f;
    [Range(0.0f, 100.0f)]
    public float playerHealth = 100f;


}
