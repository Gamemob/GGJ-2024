using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class RotateBall : MonoBehaviour
{
    public Transform[] transforms;

    public Vector2[] Positions;

    public float time;

    private int j = 0;

    private int k = 0;
    private void Awake()
    {
        transforms = new Transform[4];

       for(int i = 0;i<4;i++)
        {
            transforms[i] = transform.GetChild(i);
            transforms[i].position = Positions[i];
        }
    }

    private void Start()
    {
        StartCoroutine(ChangeBallPosition());
    }

    private void Update()
    {
        if (Time.timeScale == 0)//ÔÝÍ£
        {
            return;
        }

        if (transforms[0].tag == "test" && (Positions[0] == (Vector2)transforms[0].position)&&k == 0) 
        {
            k = 1;
            LaughValue.Instance.CurrentLaughtValue += 10;
        }
        if(Positions[0] != (Vector2)transforms[0].position)
        {
            k = 0;
        }
       
    }

    private void ChangeChild(Transform newChild)
    {
        Transform oldChild = transforms[0];
        if(newChild != null) 
        {
            newChild.position = transforms[0].position;
            transforms[0] = newChild;
            
            newChild.SetParent(this.transform);
            Destroy(oldChild.gameObject);

            j = 1;

        }
    }

    IEnumerator ChangeBallPosition()
    {
        while(true) 
        {
            if (j == 1)
            {
                j = 0;
                for (int i = 0; i < 4; i++)
                {
                    transforms[i].position = Positions[i];
                }
            }
            Vector2 position = Vector2.zero;
            for (int i = 0; i < 4; i++)
            {
                if(i == 0)
                {
                    position = transforms[i].position;
                    transforms[i].position = transforms[i+1].position;
                }
                else if(i == 3)
                {
                    transforms[i].position = position;
                }
                else
                {
                    transforms[i].position = transforms[i + 1].position;
                }
            }
        
        yield return new WaitForSeconds(time);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("enter");
        collision.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        ChangeChild(collision.transform);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        for(int i = 0;i<4;i++)
        {
            Gizmos.DrawWireSphere(Positions[i],0.5f);
        }
    }
}
