using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneToLoad; // The name of the scene you want to switch to

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish")) // Assuming collision with objects tagged as "Player"
        {
            SceneManager.LoadScene(sceneToLoad); // Switch the scene
        }
    }
}