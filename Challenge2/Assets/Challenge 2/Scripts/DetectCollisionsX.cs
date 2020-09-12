/*
*Josh Bumbalough
*Assignment2-Challenge2
*Detects collisions of objects
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private DisplayScoreX displayScoreScript;

    private void Start()
    {
        displayScoreScript = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScoreX>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScoreScript.score++;
        Destroy(gameObject);
    }
}
