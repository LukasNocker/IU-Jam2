using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenObject : MonoBehaviour
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
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("oh i found a cookie");

                //Spawn game Object: Cookie
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
