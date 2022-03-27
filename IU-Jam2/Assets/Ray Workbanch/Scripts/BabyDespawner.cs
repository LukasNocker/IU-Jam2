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
            print("Kollision mit Spieler wurde vom Despawner erkannt!");
            babySammelbar.SetActive(false);
        }

        print("Ohne vorherigen Text, stimmt hier etwas nicht");
    }
}
