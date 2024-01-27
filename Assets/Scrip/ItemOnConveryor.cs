using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ItemOnConveryor : MonoBehaviour
{
    public float moveSpeed;//移动速度
    private SpriteRenderer itemRender;
    public bag bag;
    // Start is called before the first frame update
    void Start()
    {

        itemRender = GetComponent<SpriteRenderer>();  
        print(itemGenerateManager.Instance.stageNum);
        itemRender.sprite = bag.items[itemGenerateManager.Instance.stageNum - 1].ItemSprite;
    }
    private void OnEnable()
    {
        //更新sprite到传送带道具里
      
    }
    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale == 0)
        {
            return;
        }
        this.transform.position = Vector3.MoveTowards(this.transform.position,GameObject.FindGameObjectWithTag("deleteItemconveyor").transform.position,moveSpeed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("deleteItemconveyor"))
        {
            Destroy(this.gameObject);
        }
    }
}
