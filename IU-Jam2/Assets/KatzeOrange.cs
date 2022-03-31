using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KatzeOrange : MonoBehaviour
{
    private bool interact;

    public GameObject Charakter;

    CharakterController charakterController;

    public GameObject cookie1;
    public GameObject cookie2;


    public GameObject WBBneed4;
    public GameObject WBBhave4;

    private void Start()
    {
        interact = false;

        cookie1.SetActive(false);
        cookie2.SetActive(false);
      

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

                    cookie1.SetActive(true);
                    cookie2.SetActive(true);
                   

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
                WBBhave4.SetActive(true);

            }

            if (charakterController.waschbärbabys <= 4)
            {
                WBBneed4.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = false;

            WBBhave4.SetActive(false);
            WBBneed4.SetActive(false);
        }
    }
}
