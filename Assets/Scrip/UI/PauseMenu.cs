using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)&&Time.timeScale == 0)
        {
            Resume();
        }
    }
    public void Resume()
    {
        this.gameObject.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void Restart()
    {
        Debug.Log("Restart");
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(currentSceneIndex);
    }
    public void back()
    {
        Scene_Manager.Instance.BacktoMenu();
    }
}
