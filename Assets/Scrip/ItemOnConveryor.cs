using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemOnConveryor : MonoBehaviour
{
    public float moveSpeed;//�ƶ��ٶ�
    private SpriteRenderer itemRender;
    public Transform deletePosition;
    public bag bag;
    // Start is called before the first frame update
    void Start()
    {

        itemRender = GetComponent<SpriteRenderer>();
        if (itemGenerateManager.Instance.generateNum.Count == 1)//�ж��Ƿ�ֻ��һ�����Σ�ֻ��һ������������
        {
            itemRender.sprite = bag.items[itemGenerateManager.Instance.generateNum[0] - 1].ItemSprite;
        }
        else if(itemGenerateManager.Instance.generateNum.Count >1)//��ֹһ������ͨ���ڶ���Ԫ�ظ�ֵ
        {
            itemRender.sprite = bag.items[itemGenerateManager.Instance.generateNum[1] - 1].ItemSprite;//���ݵڶ�����ֵԪ��
            itemGenerateManager.Instance.generateNum[0] = itemGenerateManager.Instance.generateNum[1];//�Ȱѵڶ�����ֵ����һ��
            itemGenerateManager.Instance.generateNum.RemoveAt(1);//���Ƴ��ڶ���Ԫ��
        }
    }
    private void OnEnable()
    {
        //����sprite�����ʹ�������
      
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
            if (SaluteFireManager.Instance.generateNum.Count == 0)//��ĿΪ0����Ϊ��һ������
            {
                SaluteFireManager.Instance.generateNum.Add(1);
                
            }
            else//��Ŀ��Ϊ����Ϊ��һ������
            {
                SaluteFireManager.Instance.generateNum.Add(SaluteFireManager.Instance.generateNum[SaluteFireManager.Instance.generateNum.Count - 1] + 1);//���֮ǰȥ�ж������ĸ���
            }
            SaluteFireManager.Instance.Fire();//������嵥�������в�����static��
            Destroy(this.gameObject);
        }
    }
}
