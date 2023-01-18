using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S_StageChanger : MonoBehaviour
{

    public C_BossTemplate[] boss = new C_BossTemplate[3];

    public Sprite stage1Sprite;
    public Sprite stage2Sprite;
    public Sprite stage3Sprite;

    public MonoBehaviour stage1AI;
    public MonoBehaviour stage2AI;
    public MonoBehaviour stage3AI;

    // Start is called before the first frame update
    void Start()
    {
        boss[0] = new C_BossTemplate("Stage 1", "Stage 1 Begins", 1, stage1Sprite, stage1AI);
        boss[1] = new C_BossTemplate("Stage 2", "Stage 2 Begins", 2, stage2Sprite, stage2AI);
        boss[2] = new C_BossTemplate("Stage 3", "Stage 3 Begins", 3, stage3Sprite, stage3AI);
    }

}
