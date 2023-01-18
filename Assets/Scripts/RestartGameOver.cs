using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGameOver : MonoBehaviour
{

    public void Restart(int LevelIndex)
    {
        SceneManager.LoadScene("LevelIndex");
    }
}
