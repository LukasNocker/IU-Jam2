using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatzeSchwarz : MonoBehaviour
{
    private bool interact;

    public GameObject Charakter;

    CharakterController charakterController;

    


    public GameObject WBBneed7;
    public GameObject WBBhave7;

    private void Start()
    {
        interact = false;

        

        charakterController = Charakter.GetComponent<CharakterController>();
    }

    private void Update()
    {
        if (charakterController.waschbärbabys >= 7)
        {
            if (interact == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(gameObject);

                   

                    interact = false;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = true;

            if (charakterController.waschbärbabys >= 7)
            {
                WBBhave7.SetActive(true);

            }

            if (charakterController.waschbärbabys <= 6)
            {
                WBBneed7.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = false;

            WBBhave7.SetActive(false);
            WBBneed7.SetActive(false);
        }
    }
}
