using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextDisplayController3 : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    private void Update()
    {
        int playerPrefValue = PlayerPrefs.GetInt("PlayerPref");
        int playerPrefValue2 = PlayerPrefs.GetInt("Lesson");
        if (playerPrefValue == 0 || playerPrefValue == 1 || playerPrefValue == 2)
        {
            textMesh.text = "Mais qu'est-ce que tu fais ici ? Va à l'hangar et cherche le document sur les profils d'ailes !";
        }
        else if (playerPrefValue == 3 && playerPrefValue2 == 0)
        {
            textMesh.text = "Maintenant qu'on a le document, commençons la construction de l'aile !";
        }
        else if (playerPrefValue == 3 && playerPrefValue2 == 1)
        {
            textMesh.text = "L'aile est déjà construite, qu'est-ce que tu attends ? Monte dans l'avion et quitte cette île !";
        }
    }
}
