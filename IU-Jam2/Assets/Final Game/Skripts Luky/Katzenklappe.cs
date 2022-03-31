using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katzenklappe : MonoBehaviour
{
    private bool search;

    public GameObject katzenklappeInteraction;
    public GameObject player;

    public GameObject WBBneed2;
    public GameObject WBBhave2;

    public GameObject Charakter;

    CharakterController charakterController;

    public GameObject canvas;
    public GameObject finalcutscene;

    public GameObject cutCanvas;
    
    // Start is called before the first frame update
    void Start()
    {
        search = false;
        katzenklappeInteraction.SetActive(false);
        charakterController = Charakter.GetComponent<CharakterController>();

        cutCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
            katzenklappeInteraction.SetActive(false);
           
            
                canvas.SetActive(true);
                cutCanvas.SetActive(false);
                finalcutscene.SetActive(false);
                
            
        }
       
        if (search == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && charakterController.waschbärbabys >= 2) 
            {
               

                player.transform.position = new Vector2(19, 1);
                search = false;

                canvas.SetActive(false);
                cutCanvas.SetActive(true);
                finalcutscene.SetActive(true);

               
                
            }
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           

            katzenklappeInteraction.SetActive(true);
            search = true;

            if(charakterController.waschbärbabys <= 1)
            {
                WBBneed2.SetActive(true);
            }

            else if(charakterController.waschbärbabys >=2)
            {
                WBBhave2.SetActive(true);
            }
        }

       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            WBBneed2.SetActive(false);
            WBBhave2.SetActive(false);

            search = false;


        }
    }
}
