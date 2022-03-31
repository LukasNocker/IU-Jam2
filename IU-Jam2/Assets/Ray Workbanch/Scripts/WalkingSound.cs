using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;

public class WalkingSound : MonoBehaviour
{
  private float playerPositionOldX;
  private float playerPositionOldY;
  private float positionSpielerCharX;
  private float positionSpielerCharY;
  private bool charInBewegung = false;
  
  public GameObject SpielerChar;
  public AudioSource Laufen;
  // Play
  void playRunSound()
  {
    Laufen.Play(); //Loop? 
  }

  void stopRunSound()
  {
    Laufen.Stop();
  }
  private void FixedUpdate()
  {
    positionSpielerAbfragen();

    if (Input.anyKey)
    {
      playSoundWhileWalking();
      bewegungFeststellen();
    }
  }

  void playSoundWhileWalking()
  {
    print("playSoundWhileWalking wurde aufegerufen");
    if (charInBewegung == false)
    {
      if (playerPositionOldX != positionSpielerCharX || playerPositionOldY != positionSpielerCharY)
      {
        charInBewegung = true;
        playRunSound();
        print("playSoundWhileWalking wurde AKTIVIERT");
      }
    }
    else if (charInBewegung == true)
    {
        print("playSoundWhileWalking wurde DEAKTIVIERT");
        stopRunSound();
        charInBewegung = false;
    }
  }

  void positionSpielerAbfragen()
  {
    print("positionSpielerAbfragen wurde aufgerufen");
    positionSpielerCharX = SpielerChar.transform.position.x;
    positionSpielerCharY = SpielerChar.transform.position.y;
  }

  void positionAlsAltFestlegen()
  {
    print("position ALsAltFestlegen wurde aufgerufen");
    playerPositionOldX = positionSpielerCharX;
    playerPositionOldY = positionSpielerCharY;
  }

  void bewegungFeststellen()
  {
     print("bewegungFeststellen wurde aufgerufen");
     positionAlsAltFestlegen();
  }
}
