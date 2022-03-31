using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOutside : MonoBehaviour
{
    public GameObject Charakter;

    public GameObject WBB1;
    public GameObject WBB2;
    public GameObject WBB3;
    public GameObject WBB4;
    public GameObject WBB5;
    public GameObject WBB6;
    public GameObject WBB7;
    public GameObject WBB8;
    public GameObject WBB9;
    public GameObject WBB10;

    private bool interact;

    public GameObject moveicon;




    // Start is called before the first frame update
    void Start()
    {
        interact = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (interact == true && Input.GetKeyDown(KeyCode.E))
        {
            Charakter.transform.position = new Vector2(26, -3);

            WBB1.transform.position = new Vector2(26, -3);
            WBB2.transform.position = new Vector2(26, -3);
            WBB3.transform.position = new Vector2(26, -3);
            WBB4.transform.position = new Vector2(26, -3);
            WBB5.transform.position = new Vector2(26, -3);
            WBB6.transform.position = new Vector2(26, -3);
            WBB7.transform.position = new Vector2(26, -3);
            WBB8.transform.position = new Vector2(26, -3);
            WBB9.transform.position = new Vector2(26, -3);
            WBB10.transform.position = new Vector2(26, -3);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = true;

            moveicon.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            interact = false;

            moveicon.SetActive(false);
        }
    }
}
