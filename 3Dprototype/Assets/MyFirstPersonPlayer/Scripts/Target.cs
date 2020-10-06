/*Josh Bumbalough
 *Assignment 5
 *Script to manage health of targets
 */
 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health;

    public void TakeDamage(float amount)
    {
        health -= amount;

        if(health <= 0)
        {
            Die();

        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
