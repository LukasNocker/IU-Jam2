using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HouseBreakin : MonoBehaviour
{
    private bool breakin;



    // Start is called before the first frame update
    void Start()
    {
        breakin = false;

    }

    // Update is called once per frame
    void Update()
    {

        if (breakin == true)
        {
            if (Input.GetKeyDown(KeyCode.E))//&& Anzahl an WWB > ?
            {
                Debug.Log("Trigger Breakin Scene");

               
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

            breakin = true;


        }

        else
        {
            breakin = false;
        }
    }
}
