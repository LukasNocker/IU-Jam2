using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katzenklappe : MonoBehaviour
{
    private bool search;

    public GameObject katzenklappeInteraction;
    public GameObject player;

    public GameObject WBB0;
    
    // Start is called before the first frame update
    void Start()
    {
        search = false;
        katzenklappeInteraction.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
            katzenklappeInteraction.SetActive(false);
       }
       
        if (search == true)
        {
            if (Input.GetKeyDown(KeyCode.E)) // and WBB Couner = 1
            {
                Debug.Log("oh i found a cookie");

                Debug.Log("oh i flound one of my babys");
                //Trigger Brakin Cutscene

                player.transform.position = new Vector2(19, 1);
                search = false;

                WBB0.transform.position = new Vector2(19, 1);



            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Interact E");

            katzenklappeInteraction.SetActive(true);
            search = true;


        }

        else 
        {
            search = false;
        }
    }
}
