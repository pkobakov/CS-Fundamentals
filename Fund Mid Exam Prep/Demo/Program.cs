﻿using System;
using System.Linq;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
           
            
            for (int i = input.Length-1; i >= 0; i--)
            {
                
                Console.Write(input[i]);
            }


        }
                
    }
}
