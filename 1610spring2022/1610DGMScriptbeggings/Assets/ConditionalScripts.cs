using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionalScripts : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        bool isFemale = true;
        bool isTall = true;

        if (isFemale && isTall)
        {
            Console.WriteLine("You are female");
            Console.WriteLine("You are a tall female");
        }
        else
        {
            Console.WriteLine("You are not  female ");
            Console.WriteLine("You are either not female or tall");

        }

        bool iswhite = true;
        bool isskinny = false;

        if (iswhite || isskinny)
        {
            Console.WriteLine(" You are either white or skinny");
        }
        Console.ReadLine();
    }



}
