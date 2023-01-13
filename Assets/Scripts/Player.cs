using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float PlayerShift;
    public int HP, Point;
    float TimeBeen;
    public Text PointRender;
    public GameObject HpRender;
    public GameObject ReplayBotton;
    void Start()
    {
        HP = 10; Point = 0; TimeBeen = 0f;
    }

    void Update()
    {
        if(Input.GetKey("w")) {
            transform.Translate(0, PlayerShift*Time.deltaTime, 0);
            GetComponent<Animator>().SetBool("jump",true);
        }
        else {
            GetComponent<Animator>().SetBool("jump",false);
        }
        TimeBeen += Time.deltaTime;
        if(TimeBeen >= 15f) {
            TimeBeen = 0f;
            while(HP < 10) {
                if(Point >= 10) {
                    PointUpdate(-10);
                    HpUpdate(+1);
                }
                else break;
            }
        }
    }
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ceiling") {
            PointUpdate(-1);
        }
    }
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.gameObject.tag == "Enemy") {
            HpUpdate(-1);
        }
        if(other.gameObject.tag == "Point") {
            PointUpdate(+1);
        }
        Destroy(other.gameObject);
    }

    public void HpUpdate(int delta) {
        HP += delta;
        HP = HP >= 10 ? 10 : (HP <= 0 ? 0 : HP);
        for(int i = 0; i < HpRender.transform.childCount; i ++) {
            if (HP > i) HpRender.transform.GetChild(i).gameObject.SetActive(true);
            else HpRender.transform.GetChild(i).gameObject.SetActive(false);
        }

        if(HP <= 0) Die();
    }

    public void PointUpdate(int delta) {
        Point += delta;
        PointRender.text = Point.ToString();
    }

    public void Die() {
        Time.timeScale = 0f;
        ReplayBotton.SetActive(true);
    }
}
