using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private bool open;

    KeyCollect keyCollect;
    public GameObject Key;

    private void Awake()
    {
        keyCollect = Key.GetComponent<KeyCollect>();
    }
    // Start is called before the first frame update
    void Start()
    {
        open = false;
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
                    Debug.Log("Door is open");

                    keyCollect.KeySlot.SetActive(false);

                }

            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Interact E");

            // TextBox: Vöt. kann ich da ja ein Baby durchschicken
            open = true;


        }

        else
        {
            open = false;
        }
    }
}
