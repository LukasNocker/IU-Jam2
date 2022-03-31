using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevertBridgeS : MonoBehaviour
{

    

    public GameObject BridgeColl;

    public GameObject BridgeS;

    // Start is called before the first frame update

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Player"))
        {
            BridgeColl.SetActive(true);
            BridgeS.SetActive(false);
        }
    }
}
