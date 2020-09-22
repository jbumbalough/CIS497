using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rb;
    public float jumpForce;
    public ForceMode forceMode;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;

    public Animator playerAnimator;

    public ParticleSystem explosionParticle; 

    public ParticleSystem dirtParticle;

    public AudioClip jumpSound;
    public AudioClip crashSound;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        //set reference to animator comp
        playerAnimator = GetComponent<Animator>();

        //start running animator on start
        playerAnimator.SetFloat("Speed_f", 1.0f);

        //set ref to audio source
        playerAudio = GetComponent<AudioSource>();

        forceMode = ForceMode.Impulse;

        //Physics.gravity *= gravityModifier;

        if(Physics.gravity.y > -10)
        {
            Physics.gravity *= gravityModifier;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            rb.AddForce(Vector3.up * jumpForce, forceMode);

            isOnGround = false;

            //set trigger to play jump animation
            playerAnimator.SetTrigger("Jump_trig");

            //stop playing dirt on jump
            dirtParticle.Stop();

            //play jump
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }
 
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            //play dirt particle when the player hits the ground
            dirtParticle.Play();
        }
        else if(collision.gameObject.CompareTag("Obstacle"))
        {
            Debug.Log("Game Over");
            gameOver = true;

            //play death animation
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);

            //play explosion particle
            explosionParticle.Play();

            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
