using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] ItemPosition = new GameObject[6];
    public GameObject[] ItemButton = new GameObject[6];
    //������¼�����
    private int rendomPosition;
    private int rendomItem;
    public float randomCd;//���ɵ��ߵ�Cd��
    private float randomStartCd;
    // Start is called before the first frame update
    void Start()
    {
        randomStartCd = randomCd;
    }

    // Update is called once per frame
    void Update()
    {
        RendomItem();
    }
   void  RendomItem()//�������(BUTTON)������
    {
        randomCd -= Time.deltaTime;
        if (randomCd < 0)
        {
            rendomPosition = Random.Range(1, 7);
            rendomItem = Random.Range(1, 7);//�������ߣ�
            GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[rendomPosition - 1].transform.position, Quaternion.identity);
            randomCd = randomStartCd;
        }
        
    }
}
