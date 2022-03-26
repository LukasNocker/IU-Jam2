using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{

    private bool collKey;
   

    private void Start()
    {
        collKey = false;
       
    }


    private void Update()
    {
        if(collKey == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("collected");

                

            }
        }
    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            Debug.Log("Collect F");

            collKey = true;

           
        }

        else
        {
            collKey = false;
        }
    }
}
