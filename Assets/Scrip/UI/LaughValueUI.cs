using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

public class LaughValueUI : MonoBehaviour
{
    // Start is called before the first frame update
    public Image image;
    void Start()
    {
        image = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        image.fillAmount = LaughValue.Instance.CurrentLaughtValue / LaughValue.Instance.MaxLaughtValue;
    }
}
