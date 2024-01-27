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
        if(Instance !=null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }
    void Start()
    {
        StartCoroutine(LaughValueDown());
    }
    private void Update()
    {
      
    }
    // Update is called once per frame
    IEnumerator LaughValueDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            if (CurrentLaughtValue - LaughValuedis >= 0)
            {
                CurrentLaughtValue -= LaughValuedis;
            }
            else
            {
                CurrentLaughtValue = 0;
            }
        }
       
    }
}
