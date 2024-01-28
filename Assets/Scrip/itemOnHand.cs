using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemOnHand : MonoBehaviour
{
    private SpriteRenderer itemRender;
    public bag bag;
    public float changeBackTime;//恢复原来的图片
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
            if (RotateBallManager.Instance.generateNum.Count == 1)//判断是否只有一个整形，只有一个整形则不消除
            {
                itemRender.sprite = bag.items[RotateBallManager.Instance.generateNum[0] - 1].ItemSprite;
                StartCoroutine("ItemEffect", RotateBallManager.Instance.generateNum[0]-1);//道具生效的携程
            }
            else if (RotateBallManager.Instance.generateNum.Count > 1)//不止一个，则通过第二个元素赋值
            {
                itemRender.sprite = bag.items[RotateBallManager.Instance.generateNum[1] - 1].ItemSprite;//根据第二个赋值元素
                StartCoroutine("ItemEffect",RotateBallManager.Instance.generateNum[1] - 1);//道具生效的携程
                RotateBallManager.Instance.generateNum[0] = RotateBallManager.Instance.generateNum[1];//先把第二个赋值给第一个
                RotateBallManager.Instance.generateNum.RemoveAt(1);//再移除第二个元素
              
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
