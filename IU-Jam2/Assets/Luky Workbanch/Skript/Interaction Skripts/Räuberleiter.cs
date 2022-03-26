using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Räuberleiter : MonoBehaviour
{
    private bool ladderbuild;
    


    // Start is called before the first frame update
    void Start()
    {
        ladderbuild = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (ladderbuild == true)
        {
            if (Input.GetKeyDown(KeyCode.E))//&& Anzahl an WWB > ?
            {
                Debug.Log("Ladder has been build");

                //Activate Game Object: Ladder
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

            ladderbuild = true;


        }

        else
        {
            ladderbuild = false; 
        }
    }
}
