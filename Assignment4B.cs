/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment4B
*/

using System;

class Assignment4B
{

    public static void Main(string[] args)
    {
        Console.WriteLine("[Plus Sign ASCII Art]");
        Console.Write("Font-size: ");
        int dim = int.Parse(Console.ReadLine());
        Console.Write("Font-weight: ");
        int weight = int.Parse(Console.ReadLine());
        Console.WriteLine("Drawing with text...");
        int size = (dim * 2) + weight;

        int midA = dim + 1;
        int midB = dim + weight;


        for (int i = 1; i <= size; i++)
        {
            if (i >= midA && i <= midB)
            {
                for (int k = 1; k <= size; k++)
                {
                    Console.Write("-");
                }
            }
            else
            {
                for (int j = 1; j <= size; j++)
                {
                    if (j >= midA && j <= midB)
                    {
                        Console.Write("|");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

            }
            Console.WriteLine();
        }
    }
}