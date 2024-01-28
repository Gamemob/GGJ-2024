using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorial : MonoBehaviour
{
    private void Awake()
    {
        Time.timeScale = 0;
    }
    public void tutorialPenalOff()
    {
        Time.timeScale = 1.0f; 
        this.gameObject.SetActive(false);
    }
}
