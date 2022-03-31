using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
   /*   Sounds müssen in die entsprechenden Scripts gezogen werden um im richtigen Moment ausgeführt werden zu können.
        Music muss an entsprechender Stelle de-/aktiviert werden.
        */
   // Header
   public AudioSource MenuSound;
   // Start
   void playMenuSound()
   {
       MenuSound.Play();
   }

   // Stop
   void stopMenuSound()
   {
       MenuSound.Stop();
   }

   // Header
   public AudioSource SpielSound;
   // Start
   void playSpielSound()
   {
       SpielSound.Play();
   }

   // Stop
   void stopSpielSound()
   {
       SpielSound.Stop();
   }

   // Header
   public AudioSource Click;
   // Play
   void playClickSound()
   {
       Click.Play();
   }
   // Header
   
  
   // Header
   public AudioSource WaschbaerHappy;
   // Play
   void playWaschbaerHappySound()
   {
       WaschbaerHappy.Play();
   }
   // Header
   public AudioSource WaschbaerWuetend;
   // Play
   void playWaschbaerWuetendSound()
   {
       WaschbaerWuetend.Play();
   }
   // Header
   
   
   // Header
   public AudioSource BumpAndKeyDrop;
   // Play
   void playBumpAndKeyDropSound()
   {
       BumpAndKeyDrop.Play();
   }
   // Header
   public AudioSource TuerOeffnen;
   // Play
   void playTuerOeffnenSound()
   {
       TuerOeffnen.Play();
   }
}
