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
        //������ͼ�����
        if (SaluteFireManager.Instance.generateNum.Count == 1)//�ж��Ƿ�ֻ��һ�����Σ�ֻ��һ������������
        {
            SaluteRen.sprite = bag.items[SaluteFireManager.Instance.generateNum[0] - 1].ItemSprite;
        }
        else if (SaluteFireManager.Instance.generateNum.Count > 1)//��ֹһ������ͨ���ڶ���Ԫ�ظ�ֵ
        {
            print(SaluteFireManager.Instance.generateNum[1]);
            SaluteRen.sprite = bag.items[SaluteFireManager.Instance.generateNum[1] - 1].ItemSprite;//���ݵڶ�����ֵԪ��
            SaluteFireManager.Instance.generateNum[0] = SaluteFireManager.Instance.generateNum[1];//�Ȱѵڶ�����ֵ����һ��
            SaluteFireManager.Instance.generateNum.RemoveAt(1);//���Ƴ��ڶ���Ԫ��
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
            if (RotateBallManager.Instance.generateNum.Count == 0)//��ĿΪ0����Ϊ��һ������
            {
                RotateBallManager.Instance.generateNum.Add(1);
            }
            else//��Ŀ��Ϊ����Ϊ��һ������
            {
                RotateBallManager.Instance.generateNum.Add(RotateBallManager.Instance.generateNum[RotateBallManager.Instance.generateNum.Count - 1] + 1);//���֮ǰȥ�ж������ĸ���
            }
            Destroy(this.gameObject);
        }
    }
}
