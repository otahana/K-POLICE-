using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
  Text HighScoreText;

    // Start is called before the first frame update
    void Start()
    {
       HighScoreText = GetComponent<Text>(); 
    }

    // Update is called once per frame
    void Update()
    {
      if(Restart.highScore < SC_2DCoin.totalCoins)
      {
        HighScoreText.text = SC_2DCoin.totalCoins.ToString();

      }

        
    }
}
