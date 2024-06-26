﻿using System;

// This is the beginning of the Exercise26 class
public class Exercise26
{
    public static void Main()
    {
        Console.WriteLine("\nSum of the first 500 prime numbers: ");

        int sum = 0; 
        int ctr = 0; 
        int n = 2; 

       
        while (ctr < 500)
        {
            if (isPrime(n))
            {
                sum += n;
                ctr++;
            }
            n++; 
        }

        Console.WriteLine(sum); 
    }

    public static bool isPrime(int n)
    {
        int x = (int)Math.Floor(Math.Sqrt(n)); 

        if (n == 1) return false; 
        if (n == 2) return true; 
        for (int i = 2; i <= x; ++i)
        {
            if (n % i == 0) return false; 
        }

        return true; 
    }
}
