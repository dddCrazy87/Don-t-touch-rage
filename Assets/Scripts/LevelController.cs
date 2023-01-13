using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelController : MonoBehaviour
{
    float TimeBeen; int level;
    void Start()
    {
        TimeBeen = 0f;
        level = 1;
    }

    public Text LevelRender;
    void Update()
    {
        TimeBeen += Time.deltaTime;
        if(TimeBeen >= 15f) {
            TimeBeen = 0f;
            Time.timeScale += 0.25f;
            level ++;
            LevelRender.text = level.ToString();
        }
    }
}
