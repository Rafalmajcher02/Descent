using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Update_Health : MonoBehaviour
{
    //Game Objects and Scripts
    [Header("Scripts + Game Objects")]
    [Space(10)]
    [Tooltip("Drag in Game Object from the scene that has Temp_Boss_ScriptLoader (Possibly 'Boss')")]
    public Temp_Boss_ScriptLoader tbs;

    //Text Mesh Pro
    [Header("Text Mesh Pro")]
    [Space(10)]
    [Tooltip("Drag in the text from the scene that you want to display boss's health with.")]
    public TextMeshProUGUI healthText;
    [Tooltip("Drag in the text from the scene that you want to display boss's name with.")]
    public TextMeshProUGUI stageText;

    //Other
    private float healthDisplay;
    private string stageDisplay;
    

    private void Start()
    {
        healthDisplay = tbs.bossHealth;
        stageDisplay = tbs.bossName;             
    }
    private void Update()
    {
        healthUpdater();
        stageUpdater();
    }
    private void healthUpdater()
    {
        healthDisplay = tbs.bossHealth;
        healthDisplay.ToString(); //Converts float to string
        healthText.text = ("Health: " + healthDisplay); //Updates Text
    }
    private void stageUpdater()
    {
        stageDisplay = tbs.bossName;
        stageText.text = ("Stage: " + stageDisplay);
    }
}
