using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    public GameObject[] ItemPosition = new GameObject[6];
    public GameObject[] ItemButton = new GameObject[7];
    //用来记录随机数
    private int rendomPosition;
    private int rendomItem;
    public float randomCd;//生成道具的Cd；
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
    void RendomItem()//随机道具(BUTTON)的生成
    {
        if (guankaNum == 0)
        {
            randomCd -= Time.deltaTime;
            haveEmpty =true;
            //for (int i = 0; i < 6; i++)
            //{
            //    if (itemsGenerate[i] == false)//有一个空的
            //    {
            //        haveEmpty = true;
            //        break;
            //    }
            //}
            if (randomCd < 0 && haveEmpty == true)
            {
                rendomPosition = Random.Range(1, 7);//生成一到六
                rendomItem = Random.Range(1, 6);//五个道具
                if (itemsGenerate[rendomPosition - 1] == false)//判断此位置是否为空
                {
                    GameObject g1;
                    itemsGenerate[rendomPosition - 1] = true;
                    g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[rendomPosition - 1].transform.position, Quaternion.identity);//在此位置生成
                    g1.GetComponent<ItemButton>().IdexOnButton = rendomPosition - 1;
                }
                else
                {
                    rendomShunxuNum = Random.Range(1, 3);//随机正反向
                    if (rendomShunxuNum == 1)//正向
                    {
                        for (int i = 0; i < 6; i++)//正向找空位
                        {
                            if (itemsGenerate[i] == false)//判断是否有物体在此位置(是否空）
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//在此位置生成
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                    else if (rendomShunxuNum == 2)
                    {
                        for (int i = 5; i >= 0; i--)//反向找空位
                        {
                            if (itemsGenerate[i] == false)//判断是否有物体在此位置（是否空）
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//在此位置生成
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
                if (itemsGenerate[i] == false)//有一个空的
                {
                    haveEmpty = true;
                    break;
                }
            }
            if (randomCd < 0 && haveEmpty == true)
            {
                rendomPosition = Random.Range(1, 7);//生成一到六
                rendomItem = Random.Range(1, 8);//五个道具
                if (itemsGenerate[rendomPosition - 1] == false)//判断此位置是否为空
                {
                    GameObject g1;
                    itemsGenerate[rendomPosition - 1] = true;
                    g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[rendomPosition - 1].transform.position, Quaternion.identity);//在此位置生成
                    g1.GetComponent<ItemButton>().IdexOnButton = rendomPosition - 1;
                }
                else
                {
                    rendomShunxuNum = Random.Range(1, 3);//随机正反向
                    if (rendomShunxuNum == 1)//正向
                    {
                        for (int i = 0; i < 6; i++)//正向找空位
                        {
                            if (itemsGenerate[i] == false)//判断是否有物体在此位置(是否空）
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//在此位置生成
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                    else if (rendomShunxuNum == 2)
                    {
                        for (int i = 5; i >= 0; i--)//反向找空位
                        {
                            if (itemsGenerate[i] == false)//判断是否有物体在此位置（是否空）
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//在此位置生成
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
                if (itemsGenerate[i] == false)//有一个空的
                {
                    haveEmpty = true;
                    break;
                }
            }
            if (randomCd < 0 && haveEmpty == true)
            {
                rendomPosition = Random.Range(1, 7);//生成一到六
                rendomItem = Random.Range(1, 10);//五个道具
                if (itemsGenerate[rendomPosition - 1] == false)//判断此位置是否为空
                {
                    GameObject g1;
                    itemsGenerate[rendomPosition - 1] = true;
                    g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[rendomPosition - 1].transform.position, Quaternion.identity);//在此位置生成
                    g1.GetComponent<ItemButton>().IdexOnButton = rendomPosition - 1;
                }
                else
                {
                    rendomShunxuNum = Random.Range(1, 3);//随机正反向
                    if (rendomShunxuNum == 1)//正向
                    {
                        for (int i = 0; i < 6; i++)//正向找空位
                        {
                            if (itemsGenerate[i] == false)//判断是否有物体在此位置(是否空）
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//在此位置生成
                                itemsGenerate[i] = true;
                                g1.GetComponent<ItemButton>().IdexOnButton = i;
                                break;
                            }
                        }
                    }
                    else if (rendomShunxuNum == 2)
                    {
                        for (int i = 5; i >= 0; i--)//反向找空位
                        {
                            if (itemsGenerate[i] == false)//判断是否有物体在此位置（是否空）
                            {
                                GameObject g1;
                                g1 = GameObject.Instantiate(ItemButton[rendomItem - 1], ItemPosition[i].transform.position, Quaternion.identity);//在此位置生成
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
