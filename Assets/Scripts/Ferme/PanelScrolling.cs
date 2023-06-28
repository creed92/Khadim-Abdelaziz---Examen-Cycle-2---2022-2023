using UnityEngine;

public class PanelScrolling : MonoBehaviour
{
    public GameObject[] panels;
    public GameObject FirstPanel;
    public GameObject Wing;


    public int currentPanelIndex = 0;

    private void Start()
    {
        int playerPrefValue = PlayerPrefs.GetInt("Lesson");
        if (playerPrefValue == 1)
        {
            Wing.SetActive(true);
        }
        ShowPanel(currentPanelIndex);
        
    }

    public void NextPanel()
    {
        HidePanel(currentPanelIndex);
        currentPanelIndex = (currentPanelIndex + 1) % panels.Length;
        ShowPanel(currentPanelIndex);
    }

    public void Exit()
    {
        HidePanel(currentPanelIndex);
        FirstPanel.SetActive(false);
        Wing.SetActive(true);
        PlayerPrefs.SetInt("Lesson", 1);
    }

    private void ShowPanel(int index)
    {
        panels[index].SetActive(true);
    }

    private void HidePanel(int index)
    {
        panels[index].SetActive(false);
    }
}

