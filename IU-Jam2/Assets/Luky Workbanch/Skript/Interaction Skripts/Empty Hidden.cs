using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyHidden : MonoBehaviour
{
    private bool search;
    
    // Start is called before the first frame update
    void Start()
    {
        search = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (search == true)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("seems to be Empty");
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Interact E");

            search = true;


        }

        else
        {
            search = false;
        }
    }
}
