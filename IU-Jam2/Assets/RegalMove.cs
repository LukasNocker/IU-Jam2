using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegalMove : MonoBehaviour
{
   public GameObject Charakter;

    public GameObject WBBneed3;
    public GameObject WBBhave3;

    private bool interact;

    CharakterController charakterController; 
    
    // Start is called before the first frame update
    void Start()
    {
        charakterController = Charakter.GetComponent<CharakterController>();

        interact = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(interact == true && Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector2(19, 2);
        }
    }
   
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
           

           if(charakterController.waschbärbabys >=3)
           {
                interact = true;
                WBBhave3.SetActive(true);
            }
           
           else if(charakterController.waschbärbabys <=2)
            {
                WBBneed3.SetActive(true);
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            interact = false;
           
            WBBneed3.SetActive(false);
            WBBneed3.SetActive(false);
        }
    }
}
