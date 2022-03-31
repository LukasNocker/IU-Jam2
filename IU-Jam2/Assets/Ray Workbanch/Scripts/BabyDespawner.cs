using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BabyDespawner : MonoBehaviour
{
    public GameObject babySammelbar;

    private bool WBBcollected;
    GameObject WWBtoDetroy;


    private void Start()
    {
        WBBcollected = false;
    }

    private void Update()
    {
      if(WBBcollected == true)
      {
         if(Input.GetKeyDown(KeyCode.F))
         {
                Destroy(babySammelbar);

                WBBcollected = false;
         }
      }
    }

    void OntriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            WBBcollected = true;

            WWBtoDetroy = coll.gameObject;
        }


    }

}
