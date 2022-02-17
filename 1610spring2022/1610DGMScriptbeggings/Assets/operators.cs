using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class operators : MonoBehaviour
{
    static void Main(string[] args)
    {
        int sum1 = 100 + 50;  // 150 (100 + 50 )
        int sum2 = sum1 + 250;  // 400 (150 + 250)
        int sum3 = sum2 + sum2;  // 800 (400 + 400)
        Console.WriteLine(sum1);
        Console.WriteLine(sum2);
        Console.WriteLine(sum3);
    }

    static void Main(string[] args)
    {
        int x = 5;
        Console.WriteLine(x);
        int x = 5;
        x = x + 3;
        Console.WriteLine(x);
        int x = 5;
        x -= 3;
        Console.WriteLine(x);
        int x = 5;
        x = x * 3;
        Console.WriteLine(x);
        int x = 5;
        double x = 5;
        x /= 3; 
        Console.WriteLine(x);
        int x = 5;
        x %= 3;
        int x = 5;
        x &= 3;
        Console.WriteLine(x);
        int x = 5;
        x |= 3;
        Console.WriteLine(x);
        int x = 5;
        x ^= 3; 
        Console.WriteLine(x);
        int x = 5;
        x >>= 3; 
        Console.WriteLine(x);
        int x = 5;
        x <<= 3; 
        Console.WriteLine(x);
    }