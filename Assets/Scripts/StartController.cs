using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartController : MonoBehaviour
{
    public Image rule;
    public GameObject botton;
    void Start()
    {
        Time.timeScale = 0f;
    }

    public void start() {
        Time.timeScale = 1f;
        rule.gameObject.SetActive(false);
        botton.SetActive(false);
    }
    
}
