using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bridge : MonoBehaviour
{
    private bool bridgebuild;

    

    public GameObject uiObject;
    
    // Start is called before the first frame update
    void Start()
    {
        bridgebuild = false;

        uiObject.SetActive(false);

      
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
       
       if(Input.GetKeyDown(KeyCode.Space))
       {
            uiObject.SetActive(false);
       }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Interact E");

            bridgebuild = true;

            uiObject.SetActive(true);
           

        }

        else
        {
            bridgebuild = false;
        }
    }

   
}
