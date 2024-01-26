using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEventSystem : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameEventSystem instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    public event Action<int> OnJokerBeDisturb;
    
    public void JokerBeDisturb(int Id)
    {
        OnJokerBeDisturb(Id);
    }
}
