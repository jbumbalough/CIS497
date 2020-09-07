/*
*Josh Bumbalough
*Assignment-Prototype 1
*Allows player to control
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

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //get input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //move forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

        //move side to side
        transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime * horizontalInput);
    }
}
