﻿/*Josh Bumbalough
*Assignment 6
*Allows for player to control themself
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private float horizontalInput;
    private float forwardInput;
    public float turnSpeed;
    public float health;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
