using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WingState : MonoBehaviour
{

    public GameObject Wing;

    // Update is called once per frame
    private void Awake()
    {
        int playerPrefValue = PlayerPrefs.GetInt("Lesson");
        if (playerPrefValue == 1)
        {
            Wing.SetActive(true);
        }
    }
    
}
