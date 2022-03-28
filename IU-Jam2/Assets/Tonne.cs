using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tonne : MonoBehaviour
{
    private bool search;
    public GameObject searchIcon;
    public GameObject cookie;

    // Start is called before the first frame update
    void Start()
    {
        search = false;

        searchIcon.SetActive(false);
        cookie.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (search == true)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                Debug.Log("oh i found a cookie");
                searchIcon.SetActive(false);
                cookie.SetActive(true);

                //Spawn game Object: Cookie
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            searchIcon.SetActive(true);
            search = true;


        }

        else
        {
            search = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            searchIcon.SetActive(false);
        }
    }
}
