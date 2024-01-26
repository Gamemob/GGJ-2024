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
        Destroy(this.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void addToBag()
    {
        bag.items.Add(thisItem);//添加此物体到对象
        //生成道具到传送带（将这个Itemforbag的数据传送给物体）
        GameObject.Instantiate(itemOnConveyor, GameObject.FindGameObjectWithTag("itemGeneratePoint").transform.position, Quaternion.identity);
        itemGenerateManager.Instance.stageNum++;
        Destroy(this.gameObject);
    }
}
