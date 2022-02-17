using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class practicevariables : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int myNum = 50;
        string myName = "Kami";
        int x = 5;
        int y = 6;
        Console.WriteLine(x + y);
        int x = 5;
        int y = 6;
        int z = x+y;
        Console.WriteLine(z);
        int x =5,y=6, z=50;
        Console.WriteLine(x+y+z) ;
        
    }

    // Update is called once per frame
    void Update()
    {
     Debug.Log("Snow today might as well practice variables!");
    }
}
