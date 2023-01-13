using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    float TimeBeen;
    void Start()
    {
        TimeBeen = 0f;
    }

    void Update()
    {
        TimeBeen += Time.deltaTime;
        float num = Random.Range(0.5f,2f);
        if(TimeBeen >= (num + 1.0f)) {
            TimeBeen = 0;
            ObjGen();
        }
    }

    public GameObject[] ObjPrefabs;
    public void ObjGen() {
        int num = Random.Range(1,6);
        float xPos = 20f, yPos = -2.5f, zPos = 0f;
        for(int i = 1; i <= num; i ++) {
            GameObject tmp = Instantiate(ObjPrefabs[0], transform);
            tmp.transform.position = new Vector3(xPos, yPos, zPos);
            yPos += 0.9f;
        }

        num = Random.Range(1,5);
        xPos += Random.Range(2, 5.5f); yPos = -2.5f; zPos = 0f;
        for(int i = 1; i <= num; i ++) {
            GameObject tmp = Instantiate(ObjPrefabs[1], transform);
            tmp.transform.position = new Vector3(xPos, yPos, zPos);
            yPos += Random.Range(0.3f, 2.3f);
        }
    }
}
