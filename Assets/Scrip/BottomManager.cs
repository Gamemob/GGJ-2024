using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomManager : MonoBehaviour
{

   public void ClickLoad(int num)
    {
        Scene_Manager.Instance.ClickLoad(num);
    }
    public void Restart()
    {
        Scene_Manager.Instance.Restart();
    }
    public void Quit()
    {
        Scene_Manager.Instance.Quit();
    }
    public void BackToMenu()
    {
        Scene_Manager.Instance.BacktoMenu(); 
    }
    public void BottomSFX()
    {
        Scene_Manager.Instance.BottomSFX();
    }
    public void ClickNext()
    {
        Debug.Log("ClickNext");
        Scene_Manager.Instance.ClickNext();
    }
}
