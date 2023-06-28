using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplayController2 : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    private void Update()
    {
        int playerPrefValue = PlayerPrefs.GetInt("PlayerPref");
        int playerPrefValue2 = PlayerPrefs.GetInt("Lesson");
        if (playerPrefValue == 0 || playerPrefValue == 1 || playerPrefValue == 2)
        {
            textMesh.text = "Eh bien, qu'est-ce que tu attends ? File à l'Hangar et trouve ce document du profil d'aile !";
        }
        else if (playerPrefValue == 3 && playerPrefValue2 == 0)
        {
            textMesh.text = "Allez, ramène-toi et viens vite à la ferme pour construire l'aile !";
        }
        else if (playerPrefValue == 3 && playerPrefValue2 == 1)
        {
            textMesh.text = "Qu'est-ce que tu fais ? L'avion est prêt, il est temps de quitter l'île !";
        }
    }
}
