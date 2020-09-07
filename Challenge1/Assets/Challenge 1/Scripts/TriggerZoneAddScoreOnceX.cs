/*
*Josh Bumbalough
*Assignment-Prototype 1
*Establishes new trigger zones 
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach script to trigger zone
public class TriggerZoneAddScoreOnceX : MonoBehaviour
{
    private bool triggered = false;
    // Start is called before the first frame update
   private void OnTriggerEnter(Collider other)
   {
       if(other.CompareTag("Player") && !triggered)
       {
           triggered = true;
           ScoreManagerX.score++;
       }
   }
}
