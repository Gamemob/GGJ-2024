using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Manager : MonoBehaviour
{
   public void ClickLoad(int num)
    {
        SceneManager.LoadScene(num);
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void BacktoMenu()
    {
        SceneManager.LoadScene("Menu");
    }

}
