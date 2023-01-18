using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Boss_Stage", menuName = "Boss Stage Statistics")]
public class Boss_Stage_Template : ScriptableObject
{
    public new string name;
    public string description;

    public float speed;
    public float health;

    public bool canFly;

    public GameObject bossPrefab;
}




