using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaughValue : MonoBehaviour
{
    public static LaughValue Instance;

    public float MaxLaughtValue;
    public float CurrentLaughtValue;
    public float LaughValuedis;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
    void Start()
    {
        CurrentLaughtValue = MaxLaughtValue;
        StartCoroutine(LaughValueDown());
    }

    // Update is called once per frame
   IEnumerator LaughValueDown()
    {
        while(true)
        {
            if(CurrentLaughtValue - LaughValuedis >= 0)
            {
                CurrentLaughtValue -= LaughValuedis;
            }
            else
            {
                CurrentLaughtValue = 0;
            }
            
            yield return new WaitForSeconds(1.0f);
        }
        
    }
}
