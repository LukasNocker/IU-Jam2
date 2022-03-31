using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katzenklappe : MonoBehaviour
{
    private bool search;

   
    public GameObject player;

    public GameObject WBBneed2;
    public GameObject WBBhave2;

    public GameObject Charakter;

    CharakterController charakterController;

    public GameObject canvas;
    public GameObject finalcutscene;

    public GameObject cutCanvas;

    public GameObject Glasbroke;
    public GameObject Glasganz;
    public GameObject Splitter;

    public GameObject FensterColl;

    // Start is called before the first frame update
    void Start()
    {
        search = false;
       
        charakterController = Charakter.GetComponent<CharakterController>();

        cutCanvas.SetActive(false);
        Glasbroke.SetActive(false);
        FensterColl.SetActive(false);
        Splitter.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space))
       {
            
           
            
                canvas.SetActive(true);
                cutCanvas.SetActive(false);
                finalcutscene.SetActive(false);
            



       }
       
        if (search == true)
        {
            if (Input.GetKeyDown(KeyCode.E) && charakterController.waschbärbabys >= 2) 
            {
               

                
                search = false;

                canvas.SetActive(false);
                cutCanvas.SetActive(true);
                finalcutscene.SetActive(true);
                Splitter.SetActive(true);
                Glasbroke.SetActive(true);
                FensterColl.SetActive(true);
                Glasganz.SetActive(false);


            }
           
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           

            
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
