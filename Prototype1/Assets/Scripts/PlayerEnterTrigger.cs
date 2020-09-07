/*
*Josh Bumbalough
*Assignment-Prototype 1
*Activation of when player enters trigger zone
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEnterTrigger : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("TriggerZone"))
        {
            ScoreManager.score++;
        }
    }
    
}
