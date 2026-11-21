using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; // SceneManagerを使用するために追加

public class TimeCounter1 : MonoBehaviour
{
    // カウントダウン
    public float countdown = 5.0f;

    // 時間を表示するText型の変数
    public Text timeText;

    // Update is called once per frame
    void Update()
    {
        // 時間をカウントダウンする
        countdown -= Time.deltaTime;

        // 時間を表示する
        timeText.text = countdown.ToString("f1") + " s";

        // countdownが0以下になったとき
        if (countdown <= 0)
        {
            timeText.text = "00.00";

            // シーンを切り替える（ここでは"NextScene"に切り替える例）
            SceneManager.LoadScene("GAME OVER 2");
        }
    }
}