/*Josh Bumbalough
 *Assignment 5
 *Script to activate win trigger
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            ScoreManager.gameOver = true;
        }
    }
}
