using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Babyfollow : MonoBehaviour
{
    public float Geschwindigkeit;

    private Transform ziel;
    public GameObject WirdGefolgt;
    private float positionPlayerX;

    public float AbstandZumZielFloat;

    private float positionPlayerY;
    
    // Start is called before the first frame update
    void Start()
    {
        ziel = WirdGefolgt.GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Vector2.Distance(transform.position, ziel.position) > AbstandZumZielFloat)
        {
            transform.position = 
                Vector2.MoveTowards(transform.position, ziel.position, Geschwindigkeit * Time.deltaTime);
        }
        /* print("Position X = " + positionPlayerX + "Position Y = " + positionPlayerY); */
    }

   /* void positionSpielerAbfragen()
    {
        positionPlayerX = player.transform.position.x;
        positionPlayerY = player.transform.position.y;
    } */
}