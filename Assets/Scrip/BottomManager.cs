using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomManager : MonoBehaviour
{
   public void ClickLoad(int num)
    {
        Scene_Manager.instance.ClickLoad(num);
    }
    public void Restart()
    {
        Scene_Manager.instance.Restart();
    }
    public void Quit()
    {
        Scene_Manager.instance.Quit();
    }
    public void BackToMenu()
    {
        Scene_Manager.instance.BacktoMenu(); 
    }
    public void BottomSFX()
    {
        Scene_Manager.instance.BottomSFX();
    }
    public void ClickNext()
    {
        Scene_Manager.instance.ClickNext();
    }
}
