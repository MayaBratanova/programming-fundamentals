﻿using System;

namespace Problem11_5_Different_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (Math.Abs(num1-num2)>=4)
            {
                for (int i = num1; i <= num2; i++)
                {
                    for (int j = num1; j <= num2; j++)
                    {
                        for (int k = num1; k <= num2; k++)
                        {
                            for (int l = num1; l <= num2; l++)
                            {
                                for (int m = num1; m <= num2; m++)
                                {
                                    if (num1<=i && i<j && j<k && k<l && l<m && m<=num2)
                                    {
                                        Console.WriteLine(i + " " + j + " " + k + " " + l + " " + m);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("No");
                return;
            }
        }
    }
}
