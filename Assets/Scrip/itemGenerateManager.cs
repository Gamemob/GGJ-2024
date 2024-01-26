using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGenerateManager : MonoBehaviour
{
    public static itemGenerateManager Instance;
    public int stageNum=0;//记录要获取bag里的哪个道具
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
