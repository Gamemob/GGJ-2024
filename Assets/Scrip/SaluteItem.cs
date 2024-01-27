using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaluteItem : MonoBehaviour
{
    private Rigidbody2D SaItemRb;
    public float Speed;
    public Vector2 FireDirection;
    private SpriteRenderer SaluteRen;
    public bag bag;
    // Start is called before the first frame update
    void Start()
    {
        SaluteRen = GetComponent<SpriteRenderer>();
        SaItemRb = GetComponent<Rigidbody2D>();
        //下面是图像控制
        if (SaluteFireManager.Instance.generateNum.Count == 1)//判断是否只有一个整形，只有一个整形则不消除
        {
            SaluteRen.sprite = bag.items[SaluteFireManager.Instance.generateNum[0] - 1].ItemSprite;
        }
        else if (SaluteFireManager.Instance.generateNum.Count > 1)//不止一个，则通过第二个元素赋值
        {
            print(SaluteFireManager.Instance.generateNum[1]);
            SaluteRen.sprite = bag.items[SaluteFireManager.Instance.generateNum[1] - 1].ItemSprite;//根据第二个赋值元素
            SaluteFireManager.Instance.generateNum[0] = SaluteFireManager.Instance.generateNum[1];//先把第二个赋值给第一个
            SaluteFireManager.Instance.generateNum.RemoveAt(1);//再移除第二个元素
        }
    }

    // Update is called once per frame
    void Update()
    {
       SaItemRb.AddForce(Speed * FireDirection.normalized, ForceMode2D.Impulse);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("ItemOnHand"))
        {
            if (RotateBallManager.Instance.generateNum.Count == 0)//数目为0，则为第一次生成
            {
                RotateBallManager.Instance.generateNum.Add(1);
            }
            else//数目不为零则不为第一次生成
            {
                RotateBallManager.Instance.generateNum.Add(RotateBallManager.Instance.generateNum[RotateBallManager.Instance.generateNum.Count - 1] + 1);//添加之前去判断生成哪个数
            }
            Destroy(this.gameObject);
        }
    }
}
