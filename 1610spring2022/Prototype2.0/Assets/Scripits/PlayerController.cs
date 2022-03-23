using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class PlayerController : MonoBehaviour
public float horizontalInput;
public float speed = 10.0f;
public float xRange = 10.0f;
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
        // Keep player in bounds
    if (Transform.Position.x < -10)
    {
        Transform.Position = new Vector3(-10, Transform.Position.y, Transform.Position.z);
    }

    if (Transform.Position.x > xRange)
    {
        Transform.Position = new Vector3(xRange, Transform.Position.y, Transform.Position.z);
    } 

    {
        horizontalInput = Input.GetAxis("Horizontal");

        Transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
