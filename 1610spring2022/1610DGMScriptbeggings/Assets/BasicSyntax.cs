using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //this line is there to  tell me the x position of my object
        /*Hi there!
        * this is two lines!
        **/
        Debug.Log(transform.position.x);

        if (transform.position.y <= 5f) ;
    }


// Update is called once per frame
    void Update()
    {
     Debug.Log ("I'm about to hit the ground!"); 
    }

    {

        // this line is there to tell me the y position of my object  
        /* Snow today!
       * it was cold!
       **/
        Debug.Log(Transform.position.x);

        if (Transform.position.y <= 10f) ;
    }