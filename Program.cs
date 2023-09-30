// DMC CS Script - IsPrime Wrapper v1.0- Made By Daniel McGuire on 9/29/2023 
// Credit: Myself, GitHub Copilot, Bing Copilot.
// Copyright 2021 - 2024 Daniel McGuire Corporation
//              All Rights Reserved.
// Compiled Using dotnet on September 29th, 2023
using System;

class Program
{
    static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;
        if (number % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(number));

        for (int i = 3; i <= boundary; i += 2)
            if (number % i == 0)
                return false;

        return true;
    }

   static void Main(string[] args)
{
    if (args.Length > 0 && args[0] == "--credits")
    {   
        Console.Clear();
        Console.WriteLine("Daniel McGuire Corporation Tools");
        Console.WriteLine();
        Console.WriteLine("This script was created by Daniel McGuire");
        Console.WriteLine("Copyright (C) 2024 Daniel McGuire Corporation");
        Console.WriteLine("Please visit https://www.daniellmcguirecorporation.ml for more info");
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Daniel McGuire Corporation Tools (R)");
        Console.WriteLine("Prime Number Solver Version 1.0");
        Console.WriteLine();
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if(IsPrime(number))
            Console.WriteLine(number + " is a prime number");
        else
            Console.WriteLine(number + " is not a prime number");
    }
}
} 