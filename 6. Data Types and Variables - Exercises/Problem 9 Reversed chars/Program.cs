﻿using System;

namespace Problem_9_Reversed_chars
{
    class Program
    {
        static void Main(string[] args)
        {
            char a = char.Parse(Console.ReadLine());
            char b = char.Parse(Console.ReadLine());
            char c = char.Parse(Console.ReadLine());
            Console.WriteLine($"{c}{b}{a}");
        }
    }
}
