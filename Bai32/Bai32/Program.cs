﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise32
{
    static void Main(string[] args)
    {
        string str;
        int l = 0;
        Console.Write("Input a string : ");

        str = Console.ReadLine();

        if (str.Length > 4)
        {
            Console.WriteLine(str.Length < 4 ? str + str + str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4));
        }
    }
}
