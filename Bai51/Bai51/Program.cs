﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exercise51
{
    public static void Main()
    {
        int[] nums = { 1, 2, 5, 7, 8 };

        Console.WriteLine("\nArray1: [{0}]", string.Join(", ", nums));
        var h_val = nums[0];
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] > nums[0])
                h_val = nums[i]; 
        }

        Console.WriteLine("\nHighest value between first and last values of the said array: {0}", h_val);
    }
}
