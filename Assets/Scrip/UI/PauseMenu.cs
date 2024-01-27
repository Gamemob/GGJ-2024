using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
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
}
