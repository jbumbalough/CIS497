/*
*Josh Bumbalough
*Assignment-Prototype 1
*Makes player lose if they fall off track
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//attach this script to player

public class PlayerLoseOnFall : MonoBehaviour
{
    // Start is called before the first frame update

   void Update()
   {
       if(transform.position.y < -1)
       {
           ScoreManager.gameOver = true;
       }
   }
}
