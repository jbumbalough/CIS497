using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour, IDamageable
{
    protected float speed;
    protected int health;
    public static bool triggered;
    public Transform target;
    Rigidbody rig;

    [SerializeField] protected Weapon weapon;



    protected virtual void Awake()
    {
        weapon = gameObject.AddComponent<Weapon>();
        speed = 5f;
        health = 100;
    }

    protected abstract void Attack(int amount);

    public abstract void TakeDamage(int amount);

    
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
        triggered = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 pos = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime);
        rig.MovePosition(pos);
        transform.LookAt(target);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("hit");
            triggered = true;
        }
    }

    // void OnCollision(Collider other)
    // {
    //     if(otherObject.tag == "Player")
    //     {
    //         Destroy(gameObject);
    //         GameManager.gameOver = true;
    //     }
    // }
}
