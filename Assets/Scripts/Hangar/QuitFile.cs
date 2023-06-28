using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitFile : MonoBehaviour
{
    public GameObject panel;


    public void Quitpanel()
        {
        Time.timeScale = 1;
        panel.SetActive(false); 
        }

}
