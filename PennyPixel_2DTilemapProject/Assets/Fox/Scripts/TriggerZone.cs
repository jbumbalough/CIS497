/*Josh Bumbalough
 *Assignment 5
 *Script to activate win trigger
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    // Start is called before the first frame update
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player"))
        ScoreManager.gameOver = true;
    }
}
