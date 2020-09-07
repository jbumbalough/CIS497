/*
*Josh Bumbalough
*Assignment-Prototype 1
*Makes player lose if they go out of bounds
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutOfBoundsX : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > 80 || transform.position.y < -51)
        {
            ScoreManagerX.gameOver = true;
        }
    }
}
