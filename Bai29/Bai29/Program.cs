﻿using System;
using System.Collections.Generic;
using System.IO; 

public class Exercise29
{
    public static void Main()
    {
        FileInfo f = new FileInfo("D:\\Prn212\\Bai29\\abc.txt");
        Console.WriteLine("\nSize of a file: " + f.Length.ToString());
    }
}
