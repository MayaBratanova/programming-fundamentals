﻿using System;

namespace Problem_1_Type_Boundaries
{
    class Program
    {
        static void Main(string[] args)
        {
            //int”, “uint”, “long”, “byte” and “sbyte
            string input = Console.ReadLine();
            if (input == "int")
            {
                Console.WriteLine(int.MaxValue);
                Console.WriteLine(int.MinValue);
            }
            else if (input == "uint")
            {
                Console.WriteLine(uint.MaxValue);
                Console.WriteLine(uint.MinValue);
            }
            else if (input == "long")
            {
                Console.WriteLine(long.MaxValue);
                Console.WriteLine(long.MinValue);
            }
            else if (input == "byte")
            {
                Console.WriteLine(byte.MaxValue);
                Console.WriteLine(byte.MinValue);
            }
            else if (input == "sbyte")
            {
                Console.WriteLine(sbyte.MaxValue);
                Console.WriteLine(sbyte.MinValue);
            }

        }
    }
}
