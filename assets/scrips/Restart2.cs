using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart2 : MonoBehaviour
{
    public static int highScore;
    Text HighScoreText;

    public void SwitchScene()
    {
        SceneManager.LoadScene("stage３", LoadSceneMode.Single);
        SC_2DCoin.totalCoins = 0;
    }
}