using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemButton : MonoBehaviour
{
    public bag bag;
    public float deleteTime;//������֮����ʧ
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
        bag.items.Add(thisItem);//��Ӵ����嵽����
        //���ɵ��ߵ����ʹ��������Itemforbag�����ݴ��͸����壩
        GameObject.Instantiate(itemOnConveyor, GameObject.FindGameObjectWithTag("itemGeneratePoint").transform.position, Quaternion.identity);
        itemGenerateManager.Instance.stageNum++;
        Destroy(this.gameObject);
    }
}
