using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Check if the other object has a specific tag or name to identify your 3D object
        if (other.CompareTag("Plane"))
        {
            // Load scene 6
            SceneManager.LoadScene(6);
        }
    }
}
