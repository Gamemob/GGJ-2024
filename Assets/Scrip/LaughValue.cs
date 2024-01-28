using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LaughValue : MonoBehaviour
{
    public static LaughValue Instance;

    public float MaxLaughtValue;
    public float CurrentLaughtValue;
    public float LaughValuedis;
    public GameObject sceneEnd;
    public GameObject sceneEnd1;
    public int sceneNum;
    public bag bag;
    private void Awake()
    {
        if(Instance !=null)
        {
            Destroy(Instance);
        }
        Instance = this;
    }
    void Start()
    {
        StartCoroutine(LaughValueDown());
    }
    private void Update()
    {
      if (CurrentLaughtValue <= 0)
        {
            AudioManager.Instance.PlayMusic("Defeat");
            sceneNum = 5;
            sceneEnd.gameObject.SetActive(true);
            bag.items.Clear();
        }
      if (CurrentLaughtValue >= MaxLaughtValue)
        {
            AudioManager.Instance.PlayMusic("Victory");
            sceneNum = SceneManager.GetActiveScene().buildIndex + 1;
            sceneEnd1.gameObject.SetActive(true);
            bag.items.Clear();
        }
    }
    // Update is called once per frame
    IEnumerator LaughValueDown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            if (CurrentLaughtValue - LaughValuedis >= 0)
            {
                CurrentLaughtValue -= LaughValuedis;
            }
            else
            {
                CurrentLaughtValue = 0;
            }
        }
       
    }
}
