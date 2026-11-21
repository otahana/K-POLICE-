using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController3 : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("大和D先生", LoadSceneMode.Single);
    }
}
