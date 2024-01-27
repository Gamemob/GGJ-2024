using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBallManager : MonoBehaviour
{
    public static RotateBallManager Instance;
    public float ItemEffectTime;
    public List<int> generateNum = new List<int>();//判断生成到了第几个item的数字
    public Sprite itemNumalBall;
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
