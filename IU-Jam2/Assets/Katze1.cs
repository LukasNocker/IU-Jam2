using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Katze1 : MonoBehaviour
{
    private bool interact;

    public GameObject Charakter;

    CharakterController charakterController;

    public GameObject cookie1;
    public GameObject cookie2;
    public GameObject cookie3;

    private void Start()
    {
        interact = false;

        cookie1.SetActive(false);
        cookie2.SetActive(false);
        cookie3.SetActive(false);

        charakterController = Charakter.GetComponent<CharakterController>();
    }

    private void Update()
    {
        if(charakterController.waschbärbabys >= 1)
        {
            if (interact == true)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    Destroy(gameObject);

                    cookie1.SetActive(true);
                    cookie2.SetActive(true);
                    cookie3.SetActive(true);

                    interact = false;
                }
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            interact = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            interact = false;
        }
    }
}
