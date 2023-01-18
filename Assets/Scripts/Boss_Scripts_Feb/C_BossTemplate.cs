using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class C_BossTemplate
{
    public string bossName;
    public string bossDescribtion;
    public int bossStage;
    public Sprite bossSprite;
    public MonoBehaviour bossBehaviour;

    public C_BossTemplate(string name, string describtion, int stage, Sprite bSprite, MonoBehaviour bBehaviour)
    {
        this.bossName = name;
        this.bossDescribtion = describtion;
        this.bossStage = stage;
        this.bossSprite = bSprite;
        this.bossBehaviour = bBehaviour;
    }
    public C_BossTemplate(string name, string describtion, int stage, Sprite bSprite)
    {
        this.bossName = name;
        this.bossDescribtion = describtion;
        this.bossStage = stage;
        this.bossSprite = bSprite;       
    }
}
