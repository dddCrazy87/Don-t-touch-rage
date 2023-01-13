using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public float PointShift;
    void Start()
    {
        PointShift = 5f;
    }
    
    void Update()
    {
        transform.Translate(-1*PointShift*Time.deltaTime, 0, 0);
        if(transform.position.x < -20){
            Destroy(gameObject);
        }
    }
}
