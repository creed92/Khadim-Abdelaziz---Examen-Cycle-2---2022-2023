using UnityEngine;
using TMPro;

public class TextDisplayController : MonoBehaviour
{
    public TextMeshProUGUI textMesh;

    private void Update()
    {
        int playerPrefValue = PlayerPrefs.GetInt("PlayerPref");

        switch (playerPrefValue)
        {
            case 0:
                textMesh.text = "H� gamin ! Qu'est-ce que tu attends ? Cherche les documents, on n'a pas toute la journ�e.";
                break;
            case 1:
                textMesh.text = "Ah non ! �a n'a rien � voir avec les profils d'ailes, cherche encore.";
                break;
            case 2:
                textMesh.text = "H�! j'ai le droit de prendre une sieste, non ? Ce n'est pas le bon document...";
                break;
            case 3:
                textMesh.text = "Bah voil� ! Tu l'as trouv�. Allez, ram�ne-toi et viens � la ferme pour construire l'aile.";
                break;
            default:
                textMesh.text = "";
                break;
        }
    }
}
