using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    private bool bridgebuild;
    private bool bridgeInteract;

    
    // Start is called before the first frame update
    void Start()
    {
        bridgebuild = false;
      
    }

    // Update is called once per frame
    void Update()
    {

       if(bridgebuild == true)
       {
            if (Input.GetKeyDown(KeyCode.E))//&& Anzahl an WWB > ?
            {
                Debug.Log("Bridge has been build");

                //Activate Game Object: Bridge
            }

            else
            {
                Debug.Log("Not enuoght racoon babys");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Interact E");

            bridgebuild = true;


        }

        else
        {
            bridgebuild = false;
        }
    }
}
