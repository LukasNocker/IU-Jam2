using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegalMoveKüche : MonoBehaviour
{
    public GameObject Charakter;

    public GameObject WBBneed5;
    public GameObject WBBhave5;

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
        if (interact == true && Input.GetKeyDown(KeyCode.E))
        {
            transform.position = new Vector2((float)-4.5, (float)-1.8);
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {


            if (charakterController.waschbärbabys >= 6)
            {
                interact = true;
                WBBhave5.SetActive(true);
            }

            else if (charakterController.waschbärbabys <= 5)
            {
                WBBneed5.SetActive(true);
            }
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = false;

            WBBneed5.SetActive(false);
            WBBneed5.SetActive(false);
        }
    }
}
