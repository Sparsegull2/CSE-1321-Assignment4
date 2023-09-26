/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Assignment4A
*/

using System;

class Assignment4A
{

    public static void Main(string[] args)
    {
        Console.WriteLine("[Stopping Time]");
        float slow = 0, sec = 0,time=0;
        float dis = 0,mph=0;
        Console.Write("How fast are you going (miles/hour)? ");
         mph= int.Parse(Console.ReadLine());
        Console.Write("How quickly can you decelerate (miles)? ");
         slow= int.Parse(Console.ReadLine());
        Console.Write("How often do you want to see updates (in seconds)? ");
         sec = int.Parse(Console.ReadLine());
        Console.WriteLine("\nYou are going " +mph+ " MPH when you slam on the brakes!");
        
        while (mph > 0)
        {
                       
            dis += mph*5280/3600;
            mph -= slow ;
            time += 1;
            if (mph < 0) break;
            if (time % sec == 0)
            {
                if (time == 1) Console.WriteLine("At " + time + " second, you have traveled " + dis.ToString("n4") + " feet and are now moving at " + mph + " MPH.");
                else Console.WriteLine("At " + time + " seconds, you have traveled " + dis.ToString("n4") + " feet and are now moving at " + mph + " MPH.");
            }
        }
        Console.WriteLine("\nYou took "+time+" seconds to stop and traveled "+dis.ToString("n4") + " feet during that time!");
    }
}
