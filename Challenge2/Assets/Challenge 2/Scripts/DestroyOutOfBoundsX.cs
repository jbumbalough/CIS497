﻿/*
*Josh Bumbalough
*Assignment2-Challenge2
*Destroys Objects out of bounds 
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -50;
    private float bottomLimit = -2;
    private HealthSystemX healthLevel;



    private void Start()
    {
        healthLevel = GameObject.FindGameObjectWithTag("DisplayHealthText").GetComponent<HealthSystemX>();
    }
    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // Destroy balls if y position is less than bottomLimit
        else if (transform.position.y < bottomLimit)
        {
            healthLevel.health--;
            Destroy(gameObject);
        }

    }
}