using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatzeWohnzimmer : MonoBehaviour
{
    private bool interact;

    public GameObject Charakter;

    CharakterController charakterController;




    public GameObject WBBneed5;
    public GameObject WBBhave5;

    private void Start()
    {
        interact = false;



        charakterController = Charakter.GetComponent<CharakterController>();
    }

    private void Update()
    {
        if (charakterController.waschbärbabys >= 5)
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

            if (charakterController.waschbärbabys >= 5)
            {
                WBBhave5.SetActive(true);

            }

            if (charakterController.waschbärbabys <= 5)
            {
                WBBneed5.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = false;

            WBBhave5.SetActive(false);
            WBBneed5.SetActive(false);
        }
    }
}
