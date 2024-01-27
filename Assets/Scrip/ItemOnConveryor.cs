using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemOnConveryor : MonoBehaviour
{
    public float moveSpeed;//移动速度
    private SpriteRenderer itemRender;
    public Transform deletePosition;
    public bag bag;
    // Start is called before the first frame update
    void Start()
    {

        itemRender = GetComponent<SpriteRenderer>();
        if (itemGenerateManager.Instance.generateNum.Count == 1)//判断是否只有一个整形，只有一个整形则不消除
        {
            itemRender.sprite = bag.items[itemGenerateManager.Instance.generateNum[0] - 1].ItemSprite;
        }
        else if(itemGenerateManager.Instance.generateNum.Count >1)//不止一个，则通过第二个元素赋值
        {
            itemRender.sprite = bag.items[itemGenerateManager.Instance.generateNum[1] - 1].ItemSprite;//根据第二个赋值元素
            itemGenerateManager.Instance.generateNum[0] = itemGenerateManager.Instance.generateNum[1];//先把第二个赋值给第一个
            itemGenerateManager.Instance.generateNum.RemoveAt(1);//再移除第二个元素
        }
    }
    private void OnEnable()
    {
        //更新sprite到传送带道具里
      
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, GameObject.FindGameObjectWithTag("deleteItemconveyor").transform.position, moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("deleteItemconveyor"))
        {
            if (SaluteFireManager.Instance.generateNum.Count == 0)//数目为0，则为第一次生成
            {
                SaluteFireManager.Instance.generateNum.Add(1);
                
            }
            else//数目不为零则不为第一次生成
            {
                SaluteFireManager.Instance.generateNum.Add(SaluteFireManager.Instance.generateNum[SaluteFireManager.Instance.generateNum.Count - 1] + 1);//添加之前去判断生成哪个数
            }
            SaluteFireManager.Instance.Fire();//这个物体单例了所有不用再static了
            Destroy(this.gameObject);
        }
    }
}
