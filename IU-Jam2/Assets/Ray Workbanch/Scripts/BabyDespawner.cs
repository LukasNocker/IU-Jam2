using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyDespawner : MonoBehaviour
{
    public GameObject babySammelbar;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Spieler")
        {
            babySammelbar.SetActive(false);
        }
    }
}
