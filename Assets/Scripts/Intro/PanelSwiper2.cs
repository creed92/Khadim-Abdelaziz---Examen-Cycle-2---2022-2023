using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelSwiper2 : MonoBehaviour
{
    public GameObject[] panels;
    
   


    public int currentPanelIndex = 0;

    private void Start()
    {
        PlayerPrefs.SetInt("FirstTime", 1);
     
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
        SceneManager.LoadScene(1);
        
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
