using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour 
public float horizontalInput;
public float speed = 10.0f;
public float xRange = 10.0f;
   
public GameObject projectilePrefab;
// Start is called before the first frame update
void Start()
{
    // Update is called once per frame
    void Update()

    {
        //Keep the player in bounds 
        if (Transform.position.x < -10)
        {
            Transform.position = new Vector3(-10, Transform.position.y, Transform.position.z);
        }

        if (Transform.position.x < -xRange)
        {
            Transform.position = new Vector3(-xRange, Transform.position.y, Transform.position.z);
        }

        horizontalInput = Input.GetAxis("Horizontal")

        Transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
    }
}
