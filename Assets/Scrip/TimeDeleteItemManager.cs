using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeDeleteItem : MonoBehaviour
{
    public static TimeDeleteItem Instance;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
