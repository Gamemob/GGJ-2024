using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ven : MonoBehaviour
{
    public float weiyi;
    private Vector3 startPosition;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x <= startPosition.x - weiyi)
            transform.position = startPosition;

            print("djkslaf");
            transform.Translate(-speed, 0, 0);
    }
}
