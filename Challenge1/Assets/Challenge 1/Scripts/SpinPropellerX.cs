/*
*Josh Bumbalough
*Assignment 1 - Challenge 1
*Makes propeller on plane spin
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropellerX : MonoBehaviour
{
   
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,0,1);
    }
}
