using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EnterFile : MonoBehaviour
{
    public GameObject panel;
    public GameObject panelNoDoc;
    public TextMeshProUGUI textMesh;




    public void Openpanel()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
    }

    public void OpenpaneliflessonOver()
    {
        int playerPrefValue = PlayerPrefs.GetInt("Lesson");
        int playerPrefValue2 = PlayerPrefs.GetInt("PlayerPref");

        if (playerPrefValue2 == 0|| playerPrefValue2 == 1 || playerPrefValue2 == 2)
        {
            panelNoDoc.SetActive(true);
        }
        else if (playerPrefValue2 == 3 && playerPrefValue == 0)
        {
            panel.SetActive(true);
        }
        else if (playerPrefValue == 1)
        {
            panelNoDoc.SetActive(true);
        }
    }

    public void Openpanelnote()
    {
        int playerPrefValue = PlayerPrefs.GetInt("Lesson");
        int playerPrefValue2 = PlayerPrefs.GetInt("PlayerPref");

        if (playerPrefValue == 1)
        {
            panel.SetActive(true);
        }
        else if (playerPrefValue == 0)
        {
            textMesh.text = "J'ai pas pris de notes, car on n'a pas encore construit l'aile...";
            panelNoDoc.SetActive(true);
        }
       
    }

    public void OpenAC()
    {
        int playerPrefValue = PlayerPrefs.GetInt("Lesson");
        int playerPrefValue2 = PlayerPrefs.GetInt("PlayerPref");

        if (playerPrefValue == 1)
        {
            SceneManager.LoadScene(4);
        }
        else if (playerPrefValue == 0)
        {
            textMesh.text = "L'avion est sans ailes, il ne peut pas voler comme ça....";
            panelNoDoc.SetActive(true);
        }

    }


}
