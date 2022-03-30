using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{

    private bool collKey;

    public bool KS1active;

    public GameObject KeySlot;

    private void Start()
    {
        collKey = false;
        KS1active = false;

        KeySlot.SetActive(false);
    }


    private void Update()
    {
        if(collKey == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("collected");

                Destroy(gameObject);
                KeySlot.SetActive(true);

                KS1active = true;

            }
        }
    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
           

            collKey = true;

           
        }

        else
        {
            collKey = false;
        }
    }
}
