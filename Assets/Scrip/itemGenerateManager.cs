using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemGenerateManager : MonoBehaviour
{
    public static itemGenerateManager Instance;
    public List<int> generateNum=new List<int>();//��¼Ҫ��ȡbag����ĸ�����
    public bag bag;
    // Start is called before the first frame update
    void Start()
    {
        bag.items.Clear();
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
