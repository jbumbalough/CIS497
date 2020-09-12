/*
*Josh Bumbalough
*Assignment2-Prototype2
*Detects collisions of objects
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    private DisplayScore displayScoreScript;


    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }
    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
