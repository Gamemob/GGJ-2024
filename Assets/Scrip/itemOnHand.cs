using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemOnHand : MonoBehaviour
{
    private SpriteRenderer itemRender;
    public bag bag;
    
    // Start is called before the first frame update
    void Start()
    {
        itemRender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("SaluteItem"))
        {
            print("sdkajldf");
            if (RotateBallManager.Instance.generateNum.Count == 1)//�ж��Ƿ�ֻ��һ�����Σ�ֻ��һ������������
            {
                itemRender.sprite = bag.items[RotateBallManager.Instance.generateNum[0] - 1].ItemSprite;
                StartCoroutine("ItemEffect", RotateBallManager.Instance.generateNum[0]-1);//������Ч��Я��
            }
            else if (RotateBallManager.Instance.generateNum.Count > 1)//��ֹһ������ͨ���ڶ���Ԫ�ظ�ֵ
            {
                print(RotateBallManager.Instance.generateNum[1]);
                itemRender.sprite = bag.items[RotateBallManager.Instance.generateNum[1] - 1].ItemSprite;//���ݵڶ�����ֵԪ��
                StartCoroutine("ItemEffect",RotateBallManager.Instance.generateNum[1] - 1);//������Ч��Я��
                RotateBallManager.Instance.generateNum[0] = RotateBallManager.Instance.generateNum[1];//�Ȱѵڶ�����ֵ����һ��
                RotateBallManager.Instance.generateNum.RemoveAt(1);//���Ƴ��ڶ���Ԫ��
              
            }
        }
    }
    IEnumerator ItemEffect(int Idex)
    {
        yield return new WaitForSeconds(RotateBallManager.Instance.ItemEffectTime);
        LaughValue.Instance.CurrentLaughtValue += bag.items[Idex].ChangeNum;
    }
}