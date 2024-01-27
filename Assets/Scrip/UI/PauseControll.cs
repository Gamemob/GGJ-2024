using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseControll : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject PauseMenu;
    private void Awake()
    {
        PauseMenu = GameObject.Find("ButtonPauseMenu");
    }
    void Start()
    {
        
        PauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&PauseMenu.active == false)
        {
            PauseMenu.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
