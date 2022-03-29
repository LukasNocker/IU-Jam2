using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WBBSpawner : MonoBehaviour
{
   

    public GameObject SpielerChar;

    CharakterController charakterController;



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


    private float positionSpielerCharX;
    private float positionSpielerCharY;

    private bool enoughtcookies;





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

        charakterController = GetComponent<CharakterController>();

        enoughtcookies = true;

    }
   
    private void Update()
    {


        if(enoughtcookies == true)
        {

            positionSpielerAbfragen();
            if (charakterController.waschbärbabys == 1)
            {
                /* babySammelbar1.SetActive(false); */
                babyFollower1.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower1.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 2)
            {
                /* babySammelbar2.SetActive(false); */
                babyFollower2.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower2.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 3)
            {
                /* babySammelbar4.SetActive(false); */
                babyFollower3.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower3.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 4)
            {
                babyFollower4.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower4.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 5)
            {
                babyFollower5.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower5.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 6)
            {
                babyFollower6.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower6.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 7)
            {
                babyFollower7.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower7.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 8)
            {
                babyFollower8.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower8.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 9)
            {
                babyFollower9.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower9.SetActive(true);


            }
            else if (charakterController.waschbärbabys == 10)
            {
                babyFollower10.transform.position = new Vector2(positionSpielerCharX, positionSpielerCharY);
                babyFollower10.SetActive(true);


            }

        }








    }
   

    void positionSpielerAbfragen()
    {
        positionSpielerCharX = SpielerChar.transform.position.x;
        positionSpielerCharY = SpielerChar.transform.position.y;
    }
}
