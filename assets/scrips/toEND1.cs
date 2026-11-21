using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toEND1 : MonoBehaviour
{
    public string sceneToLoad; // Specify the name of the scene to switch to.

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) // Check for collision with the player.
        {
            SceneManager.LoadScene("ENDScreen 2", LoadSceneMode.Single); // Switch scenes.

        }
    }
}