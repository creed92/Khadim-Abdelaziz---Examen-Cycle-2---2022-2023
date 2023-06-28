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
                textMesh.text = "Hé gamin ! Qu'est-ce que tu attends ? Cherche les documents, on n'a pas toute la journée.";
                break;
            case 1:
                textMesh.text = "Ah non ! Ça n'a rien à voir avec les profils d'ailes, cherche encore.";
                break;
            case 2:
                textMesh.text = "Hé! j'ai le droit de prendre une sieste, non ? Ce n'est pas le bon document...";
                break;
            case 3:
                textMesh.text = "Bah voilà ! Tu l'as trouvé. Allez, ramène-toi et viens à la ferme pour construire l'aile.";
                break;
            default:
                textMesh.text = "";
                break;
        }
    }
}
