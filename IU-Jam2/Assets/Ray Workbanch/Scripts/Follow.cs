using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public GameObject player;
    public GameObject baby1;
    public GameObject baby2;
    public GameObject baby3;
    private float positionPlayerX;
    private float positionPlayerY;
    private float positionPlayerAltX;
    private float positionPlayerAltY;
    private float positionBaby0X;
    private float positionBaby0Y;
    private float positionBaby1X;
    private float positionBaby1Y;
    private float positionBaby2X;
    private float positionBaby2Y;
    private float positionBaby3X;
    private float positionBaby3Y;
    private bool positionGewechselt;
    
    void Update()
    {
        positionSpielerAbfragen();
        positionsWechselAbfrage();
        baby1Positionieren();
        /* print("Position X = " + positionPlayerX + " Position Y = " + positionPlayerY);
        print("Position X Alt = " + positionPlayerAltX + " Position Y Alt = " + positionPlayerAltY);
        print("Position X Baby = " + positionBaby1X + " Position Y Baby = " + positionBaby1Y); */
    }
   
    void positionSpielerAbfragen()
    {
        positionPlayerX = player.transform.position.x;
        positionPlayerY = player.transform.position.y;
    }

    void positionsWechselAbfrage()
    {
        if (positionPlayerAltX == positionPlayerX && positionPlayerAltY == positionPlayerY)
        {
            ;
        }
        else
        {
            positionPlayerAltX = player.transform.position.x;
            positionPlayerAltY = player.transform.position.y;
            positionGewechselt = true;
        }
    }

    void baby1Positionieren()
    {
        if (positionGewechselt == (true))
        {
            positionBaby1X = positionPlayerAltX;
            positionBaby1Y = positionPlayerAltY;
            baby1.transform.position = new Vector2 (positionBaby1X, positionBaby1Y);
            positionGewechselt = false;
        }
    }
}