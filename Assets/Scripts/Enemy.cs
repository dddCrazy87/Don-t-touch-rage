using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float EnemyShift;
    void Start()
    {
        EnemyShift = 5f;
    }

    void Update()
    {
        transform.Translate(-1*EnemyShift*Time.deltaTime, 0, 0);
        if(transform.position.x < -20){
            Destroy(gameObject);
        }
    }
}
