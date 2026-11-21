using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart1 : MonoBehaviour
{
    public static int highScore;
    Text HighScoreText;

    public void SwitchScene()
    {
        SceneManager.LoadScene("stage２", LoadSceneMode.Single);
        SC_2DCoin.totalCoins = 0;
    }
}