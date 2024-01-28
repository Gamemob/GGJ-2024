using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] ItemPosition = new GameObject[6];
    public GameObject[] ItemButton = new GameObject[7];
    //������¼�����
    private int rendomPosition;
    private int rendomItem;
    public float randomCd;//���ɵ��ߵ�Cd��
    private float randomStartCd;
    public int guankaNum;
    private int rendomShunxuNum;
    public bool haveEmpty;
    public static Dictionary<int, bool> itemsGenerate = new Dictionary<int, bool>();
    public Transform smokeTrans;
    // Start is called before the first frame update
    void Start()
    {
        randomStartCd = randomCd;
        for (int i = 0; i < 6; i++)
        {
            itemsGenerate.Add(i,false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        RendomItem();
        smokeTrans.SetAsLastSibling();
        //print(itemsGenerate[0]);
    }

    private void OnDisable()
    {
        itemsGenerate.Clear();
    }
    void RendomItem()//�������(BUTTON)������
    {
        if (guankaNum == 0)
        {
            randomCd -= Time.deltaTime;
            haveEmpty =true;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (itemsGenerate[i] == false)//��һ���յ�
            //    {
            //        haveEmpty = true;
            //        break;
            //    }
            //}
            if (randomCd < 0 && haveEmpty == true)
            {
                rendomPosition = Random.Range(1, 7);//����һ����
                rendomItem = Random.Range(1, 6);//�������
                if (itemsGenerate[rendomPosition - 1] == false)//�жϴ�λ���Ƿ�Ϊ��
                {
                    GameObject g1;
                    itemsGenerate[rendomPosition - 1] = true;
                    g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[rendomPosition - 1].transform.position, Quaternion.identity);//�ڴ�λ������
                    g1.GetComponent<ItemButton>().IdexOnButton = rendomPosition - 1;
                }
                else
                {
                    rendomShunxuNum = Random.Range(1, 3);//���������
                    if (rendomShunxuNum == 1)//����
                    {
                        for (int i = 0; i < 6; i++)//�����ҿ�λ
                        {
                            if (itemsGenerate[i] == false)//�ж��Ƿ��������ڴ�λ��(�Ƿ�գ�
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//�ڴ�λ������
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                    else if (rendomShunxuNum == 2)
                    {
                        for (int i = 5; i >= 0; i--)//�����ҿ�λ
                        {
                            if (itemsGenerate[i] == false)//�ж��Ƿ��������ڴ�λ�ã��Ƿ�գ�
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//�ڴ�λ������
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                }
                randomCd = randomStartCd;
            }
        }
        if (guankaNum == 1)
        {
            randomCd -= Time.deltaTime;
            haveEmpty = false;
            for (int i = 0; i < 6; i++)
            {
                if (itemsGenerate[i] == false)//��һ���յ�
                {
                    haveEmpty = true;
                    break;
                }
            }
            if (randomCd < 0 && haveEmpty == true)
            {
                rendomPosition = Random.Range(1, 7);//����һ����
                rendomItem = Random.Range(1, 8);//�������
                if (itemsGenerate[rendomPosition - 1] == false)//�жϴ�λ���Ƿ�Ϊ��
                {
                    GameObject g1;
                    itemsGenerate[rendomPosition - 1] = true;
                    g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[rendomPosition - 1].transform.position, Quaternion.identity);//�ڴ�λ������
                    g1.GetComponent<ItemButton>().IdexOnButton = rendomPosition - 1;
                }
                else
                {
                    rendomShunxuNum = Random.Range(1, 3);//���������
                    if (rendomShunxuNum == 1)//����
                    {
                        for (int i = 0; i < 6; i++)//�����ҿ�λ
                        {
                            if (itemsGenerate[i] == false)//�ж��Ƿ��������ڴ�λ��(�Ƿ�գ�
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//�ڴ�λ������
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                    else if (rendomShunxuNum == 2)
                    {
                        for (int i = 5; i >= 0; i--)//�����ҿ�λ
                        {
                            if (itemsGenerate[i] == false)//�ж��Ƿ��������ڴ�λ�ã��Ƿ�գ�
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//�ڴ�λ������
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                }
                randomCd = randomStartCd;
            }
        }
        if (guankaNum == 2)
        {
            randomCd -= Time.deltaTime;
            haveEmpty = false;
            for (int i = 0; i < 6; i++)
            {
                if (itemsGenerate[i] == false)//��һ���յ�
                {
                    haveEmpty = true;
                    break;
                }
            }
            if (randomCd < 0 && haveEmpty == true)
            {
                rendomPosition = Random.Range(1, 7);//����һ����
                rendomItem = Random.Range(1, 10);//�������
                if (itemsGenerate[rendomPosition - 1] == false)//�жϴ�λ���Ƿ�Ϊ��
                {
                    GameObject g1;
                    itemsGenerate[rendomPosition - 1] = true;
                    g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[rendomPosition - 1].transform.position, Quaternion.identity);//�ڴ�λ������
                    g1.GetComponent<ItemButton>().IdexOnButton = rendomPosition - 1;
                }
                else
                {
                    rendomShunxuNum = Random.Range(1, 3);//���������
                    if (rendomShunxuNum == 1)//����
                    {
                        for (int i = 0; i < 6; i++)//�����ҿ�λ
                        {
                            if (itemsGenerate[i] == false)//�ж��Ƿ��������ڴ�λ��(�Ƿ�գ�
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//�ڴ�λ������
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                    else if (rendomShunxuNum == 2)
                    {
                        for (int i = 5; i >= 0; i--)//�����ҿ�λ
                        {
                            if (itemsGenerate[i] == false)//�ж��Ƿ��������ڴ�λ�ã��Ƿ�գ�
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//�ڴ�λ������
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                }
                randomCd = randomStartCd;
            }
        }
    }
}
