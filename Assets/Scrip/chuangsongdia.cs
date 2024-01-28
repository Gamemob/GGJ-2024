using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuangsongdia : MonoBehaviour
{
    public float speed;
    public Vector2 startPosition;
    public float weiyi;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //±³¾°ÒÆ¶¯
        if (Time.timeScale != 0)
        {
            if (transform.position.x <= startPosition.x - weiyi)
                transform.position = startPosition;
            if (Time.timeScale == 1)
            {
                transform.Translate(-speed, 0, 0);
            }
        }

    }
}
