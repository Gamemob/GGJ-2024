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
    public int  IdexOnButton;//button����ֵ
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
        bag.items.Add(thisItem);//��Ӵ����嵽����
        //���ɵ��ߵ����ʹ��������Itemforbag�����ݴ��͸����壩
        GameObject.Instantiate(itemOnConveyor, GameObject.FindGameObjectWithTag("itemGeneratePoint").transform.position, Quaternion.identity);
        if (itemGenerateManager.Instance.generateNum.Count == 0)//��ĿΪ0����Ϊ��һ������
        {
            itemGenerateManager.Instance.generateNum.Add(1);
        }
        else//��Ŀ��Ϊ����Ϊ��һ������
        {
            itemGenerateManager.Instance.generateNum.Add(itemGenerateManager.Instance.generateNum[itemGenerateManager.Instance.generateNum.Count-1]+1);//���֮ǰȥ�ж������ĸ���
        }
        ItemManager.itemsGenerate[IdexOnButton] = false;
        Destroy(this.gameObject);
    }
}
