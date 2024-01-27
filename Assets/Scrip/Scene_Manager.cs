using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Scene_Manager :baseNomonoManager<Scene_Manager>
{
    public void ClickLoad(int num)
    {
        AudioManager.Instance.PlaySFX("Bo1");
        SceneManager.LoadScene(num);
    }
    public void Restart()
    {
        AudioManager.Instance.PlaySFX("Bo1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Quit()
    {
        AudioManager.Instance.PlaySFX("Bo1");
        Application.Quit();
    }
    public void BacktoMenu()
    {
        AudioManager.Instance.PlaySFX("Bo1");
        SceneManager.LoadScene("Menu");
    }
    public void BottomSFX()
    {
        AudioManager.Instance.PlaySFX("Bo1");
    }
    public void ClickNext()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
