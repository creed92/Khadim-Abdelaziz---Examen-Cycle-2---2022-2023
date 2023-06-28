using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public GameObject NoBase;
    public void GoToScene0()
    {
        SceneManager.LoadScene(0);
    }

    public void GoToScene1()
    {
        Time.timeScale = 1;
        int playerPrefValue = PlayerPrefs.GetInt("FirstTime");
        if (playerPrefValue == 1)
        {
            
            SceneManager.LoadScene(1);
        }
        else SceneManager.LoadScene(5);
        
    }

    public void GoToScene2()
    {
        int playerPrefValue = PlayerPrefs.GetInt("PlayerPref");
        if (playerPrefValue == 3)
        {
            NoBase.SetActive(true);
        }
        else SceneManager.LoadScene(2);

        if (playerPrefValue < 3)
        {
            PlayerPrefs.SetInt("PlayerPref", 0);
        }
        
    }

    public void GoToScene3()
    {
        SceneManager.LoadScene(3);
    }

    public void GoToScene4()
    {
        SceneManager.LoadScene(4);
    }
}
