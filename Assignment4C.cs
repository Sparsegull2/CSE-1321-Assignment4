/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment4C
*/

using System;

class Assignment4C
{

    public static void Main(string[] args)
    {
        Console.WriteLine("[4 Gallons of Water]");
        int gal3 = 0, gal5 = 0;
        do
        {
            Console.WriteLine("\nThe 3 gallon can has " + gal3 + " gallons of water. The 5 gallon can has " + gal5 + " gallons of water.");
            Console.Write("\nOptions\n1) Fill the 5 gallon can from the fountain\n2) Fill the 3 gallon can from the fountain\n3) Pour the 5 gallon can into the 3 gallon jug\n4) Pour the 3 gallon can into the 5 gallon jug\n5) Empty the 5 gallon can into the fountain\n6) Empty the 3 gallon can into the fountain\nWhat will you do? ");
            int choice= int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    gal5 = 5;  
                    break;
                case 2:
                    gal3=3; 
                    break;
                case 3:
                    if (gal3 != 3)
                    {
                        if (gal5 >= 3)
                        {
                            gal5 = gal5 - (3 - gal3);
                            gal3 = 3;
                        }
                        else
                        {
                            gal3 = gal5;
                            gal5 = gal5 - gal3;
                        }                       
                    }
                    break;
                case 4:
                    if (gal5 != 5)
                    {
                        if (gal5 <= 2)
                        {
                            gal5 = gal5 + gal3;
                            gal3 = 0;
                        }
                        else
                        {
                            gal3=gal3 - 2;
                            gal5 = 5;
                                                    }
                    }
                    break;
                case 5:
                    gal5 = 0;
                    break;
                case 6:
                    gal3 = 0;
                    break;

            }
        }
        while (gal5 != 4);
        Console.WriteLine("\nThe 3 gallon can has " + gal3 + " gallons of water. The 5 gallon can has " + gal5 + " gallons of water.");
        Console.WriteLine("You saved Bruce Willis and Samuel L. Jackson! You win!");
    }
}
