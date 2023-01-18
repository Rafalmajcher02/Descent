using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Boss Stages
    public Boss_Stage_Template stage_1;
    public Boss_Stage_Template stage_2;
    public Boss_Stage_Template stage_3;

    public Temp_Boss_ScriptLoader tbs;

    public PlayerHealth ph;

    public GameObject gameOver;
    public GameObject victory;

    void Update()
    {
        Stage1HealthChecker();
    }

    private void GameOverCheck()
    {
        if (tbs.bossHealth <= 0 && tbs.stageIndex == 3)
        {
            gameOver.SetActive(true);
        }
        if (ph.curHealth == 0)
        {
            victory.SetActive(true);
        }
    }
    private void Stage1HealthChecker()
    {
        if (tbs.bossHealth < 20)
        {
            tbs.stageIndex += 1;
            tbs.StageChanger();
        }
    }

}
