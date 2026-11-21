using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Restart : MonoBehaviour
{
    public static int highScore;
    Text HighScoreText;
    
    public void SwitchScene()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

        //highScore = SC_2DCoin.NowCoins;
        SC_2DCoin.totalCoins = 0;

    }
}