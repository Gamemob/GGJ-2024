using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaluteFire : MonoBehaviour
{
    public new GameObject gameObject;

    public Rigidbody2D gameObjectRig2D;

    public float Speed;

    //public Vector2 Direction;

    private int i = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject != null&&gameObjectRig2D == null)
        {
            gameObjectRig2D = gameObject.GetComponent<Rigidbody2D>();
        }
        
        Fire();
    }

    private void Fire()
    {
        if(gameObject != null && gameObjectRig2D != null&&i == 0)
        {
            i = 1;
            gameObject.transform.position = this.transform.position;
            gameObjectRig2D.AddForce(Speed * new Vector2(1,1), ForceMode2D.Impulse);
        }
    }
}

