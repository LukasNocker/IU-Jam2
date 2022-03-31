using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeS : MonoBehaviour
{

    public GameObject bridgeS;
    public GameObject BridgeColl;
    public GameObject glitzer;

    public GameObject WBBneed4;
    public GameObject WBBhave4;

    public bool interact;

    public GameObject Charakter;

    CharakterController charakterController;

    
    
    // Start is called before the first frame update
    void Start()
    {
        bridgeS.SetActive(false);

        charakterController = Charakter.GetComponent<CharakterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if(interact == true )
        {
            if(Input.GetKeyDown(KeyCode.E) && charakterController.waschbärbabys >= 4)
            {
                bridgeS.SetActive(true);
                BridgeColl.SetActive(false);
                glitzer.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            interact = true;

            if(charakterController.waschbärbabys >=4)
            {
                WBBhave4.SetActive(true);
            }

            if (charakterController.waschbärbabys <= 3)
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
