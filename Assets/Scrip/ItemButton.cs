using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    public bag bag;
    public float deleteTime;//激活多久之后消失
    public itemForBag thisItem;
    public GameObject itemOnConveyor;
    public int  IdexOnButton;//button的数值
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnEnable()
    {
        transform.SetParent(GameObject.FindGameObjectWithTag("itemManager").transform);
        StartCoroutine("deleteThisItem");
    }
    IEnumerator deleteThisItem()
    {
        yield return new WaitForSeconds(deleteTime);
        ItemManager.itemsGenerate[IdexOnButton] = false;
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void addToBag()
    {
        AudioManager.Instance.PlaySFX("Bo");
        bag.items.Add(thisItem);//添加此物体到对象
        //生成道具到传送带（将这个Itemforbag的数据传送给物体）
        GameObject.Instantiate(itemOnConveyor, GameObject.FindGameObjectWithTag("itemGeneratePoint").transform.position, Quaternion.identity);
        if (itemGenerateManager.Instance.generateNum.Count == 0)//数目为0，则为第一次生成
        {
            itemGenerateManager.Instance.generateNum.Add(1);
        }
        else//数目不为零则不为第一次生成
        {
            itemGenerateManager.Instance.generateNum.Add(itemGenerateManager.Instance.generateNum[itemGenerateManager.Instance.generateNum.Count-1]+1);//添加之前去判断生成哪个数
        }
        ItemManager.itemsGenerate[IdexOnButton] = false;
        Destroy(this.gameObject);
    }
}
