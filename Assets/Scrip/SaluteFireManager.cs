using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaluteFireManager : MonoBehaviour
{
    public static SaluteFireManager Instance;
    public GameObject itemOnSalute;
    public Transform SaluteGenerateTrans;
    public List<int> generateNum = new List<int>();//�ж����ɵ��˵ڼ���item������
    public float waitForlunch;
    //public Vector2 Direction;



    void Start()
    {

    }
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }
    // Update is called once per frame
    void Update()
    { 

    }

    public  void Fire()
    {
        StartCoroutine("WaitForLunch");
        
    }
    IEnumerator WaitForLunch()
    {
        yield return  new WaitForSeconds(waitForlunch);
        GameObject.Instantiate(Instance.itemOnSalute, Instance.SaluteGenerateTrans.position, Quaternion.identity);
    }
}


