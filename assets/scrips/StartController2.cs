using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartController2 : MonoBehaviour
{
    public void SwitchScene()
    {
        SceneManager.LoadScene("stage３", LoadSceneMode.Single);
    }
}
