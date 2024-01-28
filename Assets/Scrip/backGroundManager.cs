using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backGroundManager : MonoBehaviour
{
    public static backGroundManager Instance;
    public Sprite meixiao;
    public Sprite xiaole;
    public SpriteRenderer zuo;
    public SpriteRenderer you;
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
    public void xiaoLe()
    {
        zuo.sprite = xiaole;
        you.sprite = xiaole;
        StartCoroutine("MeiXiao");
    }
    IEnumerator MeiXiao()
    {
        yield return new WaitForSeconds(4.5f);
        zuo.sprite = meixiao;
        you.sprite = meixiao;
    }
}
