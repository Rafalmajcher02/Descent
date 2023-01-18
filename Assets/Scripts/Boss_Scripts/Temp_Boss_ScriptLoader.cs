using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temp_Boss_ScriptLoader : MonoBehaviour
{
    //Boss Stages
    public Boss_Stage_Template stage_1;
    public Boss_Stage_Template stage_2;
    public Boss_Stage_Template stage_3;
    //Floats
    public float bossHealth;
    public string bossName;
    //Stage Changer
    public int stageIndex = 1;
    //Scripts
    public S_BossAttack ba;

    // Start is called before the first frame update
    void Start()
    {
        StageChanger();
    }

    public void StageChanger()
    {
        if (stageIndex == 1)
        {
            bossHealth = stage_1.health;
            bossName = stage_1.name;
            ba.bossDamage = 10f;
        }
        if (stageIndex == 2)
        {
            bossHealth = stage_2.health;
            bossName = stage_2.name;
            ba.bossDamage = 20f;
        }
        if (stageIndex == 3)
        {
            bossHealth = stage_3.health;
            bossName = stage_3.name;
            ba.bossDamage = 30f;
        }
    }
}
