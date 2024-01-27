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

    public Scene_Manager sceneManager;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        CurrentLaughtValue = 100;
    }
    void Start()
    {
        sceneManager = GameObject.Find("SceneManager").GetComponent<Scene_Manager>();
        StartCoroutine(LaughValueDown());
    }
    private void Update()
    {
      if(CurrentLaughtValue >= MaxLaughtValue)
        {
            
            Debug.Log("Win");
            //sceneManager.BacktoMenu();
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
