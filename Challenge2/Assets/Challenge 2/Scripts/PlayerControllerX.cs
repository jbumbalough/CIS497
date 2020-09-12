/*
*Josh Bumbalough
*Assignment2-Challenge2
*Controls for player
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldownTime = 1;
    private float nextDogReady = 0;


    // Update is called once per frame
    void Update()
    {
        if(Time.time > nextDogReady)
        {
        // On spacebar press, send dog
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                nextDogReady = Time.time + cooldownTime;
                
            }
        }
    }

}
