using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool open;

    KeyCollect keyCollect;
    public GameObject Key;

    public GameObject needkey;

    private void Awake()
    {
        keyCollect = Key.GetComponent<KeyCollect>();
    }
    // Start is called before the first frame update
    void Start()
    {
        open = false;
        needkey.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (open == true) 
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
               
                if(keyCollect.KS1active == true)
                {
                    

                    keyCollect.KeySlot.SetActive(false);
                    Destroy(gameObject);

                }

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           

            // TextBox: Vöt. kann ich da ja ein Baby durchschicken
            open = true;

            needkey.SetActive(true);


        }

       
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            open = false;

            needkey.SetActive(false);
        }
    }
}
