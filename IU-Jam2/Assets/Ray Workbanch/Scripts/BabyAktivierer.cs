using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BabyAktivierer : MonoBehaviour
{
    private int babyCounter;

    public GameObject babyFollower1;
    public GameObject babyFollower2;
    public GameObject babyFollower3;
    public GameObject babyFollower4;
    public GameObject babyFollower5;
    public GameObject babyFollower6;
    public GameObject babyFollower7;
    public GameObject babyFollower8;
    public GameObject babyFollower9;
    public GameObject babyFollower10;
    /*
    public GameObject babySammelbar1;
    public GameObject babySammelbar2;
    public GameObject babySammelbar3;
    public GameObject babySammelbar4;
    public GameObject babySammelbar5;
    public GameObject babySammelbar6;
    public GameObject babySammelbar7;
    public GameObject babySammelbar8;
    public GameObject babySammelbar9;
    public GameObject babySammelbar10;
    */
    public GameObject SpielerChar;

    private float positionSpielerCharX;
    private float positionSpielerCharY;

    private bool activateReady;

    void Start()
    {
        babyFollower1.SetActive(false);
        babyFollower2.SetActive(false);
        babyFollower3.SetActive(false);
        babyFollower4.SetActive(false);
        babyFollower5.SetActive(false);
        babyFollower6.SetActive(false);
        babyFollower7.SetActive(false);
        babyFollower8.SetActive(false);
        babyFollower9.SetActive(false);
        babyFollower10.SetActive(false);

        activateReady = false;
    }
    void addBaby()
    {
        babyCounter++;
    }

    private void Update()
    {
       
        if (activateReady == true)
        {
           if(Input.GetKeyDown(KeyCode.F))
            {
                addBaby();
                positionSpielerAbfragen();
                if (babyCounter == 1)
                {
                    /* babySammelbar1.SetActive(false); */
                    babyFollower1.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower1.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 2)
                {
                    /* babySammelbar2.SetActive(false); */
                    babyFollower2.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower2.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 3)
                {
                    /* babySammelbar4.SetActive(false); */
                    babyFollower3.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower3.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 4)
                {
                    babyFollower4.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower4.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 5)
                {
                    babyFollower5.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower5.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 6)
                {
                    babyFollower6.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower6.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 7)
                {
                    babyFollower7.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower7.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 8)
                {
                    babyFollower8.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower8.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 9)
                {
                    babyFollower9.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower9.SetActive(true);

                    activateReady = false;
                }
                else if (babyCounter == 10)
                {
                    babyFollower10.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                    babyFollower10.SetActive(true);

                    activateReady = false;
                }
            }
        }
    }
    void OnTriggerStay2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Baby")
        {
            activateReady = true;
        }

        print("Baby Counter: " + babyCounter);
    }
    void positionSpielerAbfragen()
    {
        positionSpielerCharX = SpielerChar.transform.position.x;
        positionSpielerCharY = SpielerChar.transform.position.y;
    }
}
