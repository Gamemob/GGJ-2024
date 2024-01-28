using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemOnHand : MonoBehaviour
{
    private SpriteRenderer itemRender;
    public bag bag;
    public float changeBackTime;//�ָ�ԭ����ͼƬ
    public GameObject smoke;
    public Animator sexiangjiAni;
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
        
        if (bag.items[Idex].ChangeNum > 0)
        {   
            sexiangjiAni.SetTrigger("isDong");
            AudioManager.Instance.PlaySFX("La");
            backGroundManager.Instance.xiaoLe();
        }
        else if (bag.items[Idex].ChangeNum < 0)
        {
            AudioManager.Instance.PlaySFX("Em");
        }
        if (bag.items[Idex].isSmoke&&smoke!=null)
        {
            smoke.gameObject.SetActive(true);
            StartCoroutine("smokeDelete");
        }
            LaughValue.Instance.CurrentLaughtValue += bag.items[Idex].ChangeNum;
        StartCoroutine("chagneBackSprite");
    }
    IEnumerator smokeDelete()
    {
        yield return new WaitForSeconds(5.3f);
        smoke.gameObject.SetActive(false);
    }
    IEnumerator chagneBackSprite()
    {
        yield return new WaitForSeconds(changeBackTime);
        itemRender.sprite = RotateBallManager.Instance.itemNumalBall;
    }
}
