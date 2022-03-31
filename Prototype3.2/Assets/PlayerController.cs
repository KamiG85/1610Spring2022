using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;
    public float jumpForce;
    public float gravityModifier;

    public bool isOnGround = true;
    public bool gameOver = false;
    private Animator playerAnim;
    
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;

    private AudioSource playerAudio
    public AudioClip jumpSound;
    public AudioClip crashSound;
}
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerAnime = GetComponent<Animator>();
        Physics.gravityModifier *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
             playerAudio.PlayOneShot(jumpSound, 1.0f);
            dirtParticle.Stop();
        }
        {
            playerRb.AddForce(Vector3.up jumpForce, ForceMode.Impluse);
            isOnGround = false;
            playerAnim.SetTrigger("Jump_trig");
        }
    }

    private void OnCollisionEnter(Collision collison)
    {
        if (Collision.gameObject.CompareTag("Ground"))
        {
            playerAudio.PlayOneShot(crashSound, 1.0);
            dirtParticle.Play();
        }
        {
            isOnGround = true;
        } else if (Collision.gameObject.CompareTag("Obstacle"))
        {
            ... explosionParticle.Play():;
            ... dirtParticle.Play();
        }
        {
            gameOver = true;
            Debug.Log("Game Over!");
            gameOver = true;
            playerAnim.SetBool("Death_b," true);
            playerAnim.SetInteger("DeathType_int", 1);
        }
    }
}
