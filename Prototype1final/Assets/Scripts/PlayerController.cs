using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using TMPro;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float rpm;
    [SerializeField] float horsepower = 0.0f;
    [SerializeField] float turnSpeed = 50.0f;
    private float horizontalInput;
    private float forwardInput;
    private Rigidbody playerRb;

    [SerializeField] private GameObject centerOfMass;
    [SerializeField] TextMeshProUGUI speedometerText;
    [SerializeField] TextMeshProUGUI rpmText;
    
    [SerializeField] List<WheelCollider> allWheels;
    [SerializeField] int wheelsOnGround;
   
    
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerRb.centerOfMass = centerOfMass.transform.position;
    }

    // Update is called once per frame
    void  FixedUpdate()
    {
        // Player Input  
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        if (IsOnGround)
        {
            // Moves the car forward based on vertical input
            playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
            // Rotates the car based on horizontal input 
            transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        }
        
        // Moves the car forward based on vertical input
        playerRb.AddRelativeForce(Vector3.forward * verticalInput * horsePower);
        // Rotates the car based on horizontal input 
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        
        // print speed
        speed = Mathf.Round(playerRb.velocity.magnitude * 2.237f); //3.6 for kph
        speedometerText.SetText("Speed:" + speed + "mph");
        
        //print RPM
        rpm = Mathf.Round((speed % 30) * 40);
        rpmText.SetText("RPM: " + rpm);
        
    }

    bool IsOnGround()
    {
        wheelsOnGround = 0;
        foreach (WheelCollider wheel in allWheels)
        {
            if (wheel.isGrounded)
            {
                wheelsOnGround++;
            }

            if (wheelsOnGround == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
