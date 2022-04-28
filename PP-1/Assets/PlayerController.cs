using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 30.0f;
    [SerializeField] float turnSpeed = 50.0f;
   [SerializeField] float Vector3 offset = new Vector3(0, 5, -7);
    
    private Rigidbody playerRb;
    private float zBound = 6;
    private float horizontalInput;
    private float verticalInput;

    private UnityEvent m_MyEvent;
    
    // Start is called before the first frame update
    void Awake()
    {
        if (m_MyEvent == null)
            m_MyEvent = new UnityEvent();

        m_MyEvent.AddListener(Ping);
        
        playerRb = GetComponent<Rigidbody>();
        

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        // moves  the player 
        transform.Translate(Vector3.forward * Time.deltaTime *speed * verticalInput);
        //rotation  
        transform.Translate(Vector3.right, * Time.deltaTime. *turnSpeed * horizontalInput);

        if (Input.anyKeyDown && m_MyEvent != null)
        {
            m_MyEvent.Invoke();
        }
        
        
        {
            MovePlayer();
        }
        void MovePlayer()
        

        playerRb
        playerRb.AddForce(Vector3.right * speed * horizontalInput);

        if (transform.position.z < -zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -zBound);
        }

        if (transform.position.x > zBound)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, zBound);
        }
        
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                Debug.Log("Player has collided with enemy.");
            }
        }
        
        private void OnTriggerEnter(Collision other)
        {
            if (other.gameObject.CompareTag("Powerup"))
            {
                Destroy(other.gameObject);
            }
        }

        void Ping()
        {
            Debug.Log("Ping");
        }
}
