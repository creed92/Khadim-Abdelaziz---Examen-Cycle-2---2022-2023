using UnityEngine;
using UnityEngine.UI;

public class ButtonPanelController : MonoBehaviour
{
    public GameObject panelA;
    public GameObject panelB;
    public GameObject panelC;

    private Button button;
    private static int activeButtonCount = 3;
    private static bool isFirstButtonChosen = false;
    private static bool isSecondButtonChosen = false;

    private void Start()
    {
        isFirstButtonChosen = false;
        isSecondButtonChosen = false;
        activeButtonCount = 3;
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClick);
        PlayerPrefs.SetInt("PlayerPref", 0); // Set PlayerPref to 0 for first button
        PlayerPrefs.SetInt("Lesson", 0);
    }

    private void OnClick()
    {
        // Disable the clicked button
        button.interactable = false;
        activeButtonCount--;

        // Check if it's the first button
        if (!isFirstButtonChosen)
        {
            isFirstButtonChosen = true;
            if (Random.value < 0.5f)
            {
                panelA.SetActive(true);
                panelB.SetActive(false);
            }
            else
            {
                panelA.SetActive(false);
                panelB.SetActive(true);
            }
            PlayerPrefs.SetInt("PlayerPref", 1); // Set PlayerPref to 1 for first button
        }
        else if (!isSecondButtonChosen) // Check if it's the second button
        {
            isSecondButtonChosen = true;
            if (panelA.activeSelf)
            {
                panelA.SetActive(false);
                panelB.SetActive(true);
            }
            else
            {
                panelA.SetActive(true);
                panelB.SetActive(false);
            }
            PlayerPrefs.SetInt("PlayerPref", 2); // Set PlayerPref to 2 for second button
        }
        else if (activeButtonCount==0)
        {
            panelA.SetActive(false);
            panelB.SetActive(false);
            panelC.SetActive(true);
            PlayerPrefs.SetInt("PlayerPref", 3); // Set PlayerPref to 3 for Panel C
        }

        // Destroy the button GameObject
        Destroy(button.gameObject);
    }
}
