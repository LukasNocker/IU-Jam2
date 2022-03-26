using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyAktivierer : MonoBehaviour
{
    private int babyCounter;

    public GameObject babyFollower;

    void Start()
    {
        babyFollower.SetActive(false);
    }
    void addBaby()
    {
        babyCounter++;
    }
    
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Baby")
        {
            addBaby();
            babyFollower.SetActive(true);
        }
    }
}
