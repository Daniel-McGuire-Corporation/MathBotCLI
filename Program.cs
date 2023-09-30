// DMC CS Script - IsPrime Wrapper v1.0 - First Made By Daniel McGuire on 11/08/2021
// Credit: Myself, GitHub Copilot, Bing Copilot.
// Copyright 2021 - 2024 Daniel McGuire Corporation
//              All Rights Reserved.
// Compiled Using dotnet on September 30th, 2023
// **Above Info May Be Incorrect If Downloaded From GitHub Repo**
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
    if (args.Length > 0)
    {
        switch(args[0])
        {
            case "--credits":
            case "-c":
                Console.Clear();
                Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                Console.WriteLine();
                Console.WriteLine("This Application was Written in C# by Daniel McGuire");
                Console.WriteLine("(With Help From GitHub Copilot & ChatGPT)");
                Console.WriteLine("Copyright (C) 2024 Daniel McGuire Corporation");
                Console.WriteLine("This software is under GNU GP v3 License");
                Console.WriteLine("Please visit https://www.daniellmcguirecorporation.ml for more info");
                break;
            case "--help":
            case "-h":
                Console.Clear();
                Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                Console.WriteLine("Prime Number Solver Version 1.0");
                Console.WriteLine();
                Console.WriteLine("Usage:");
                Console.WriteLine("  --credits, -c: Show credits");
                Console.WriteLine("  --help, -h: Show help");
                Console.WriteLine("  number: Check if a number is a prime number");
                Console.WriteLine();
                Console.WriteLine("Example: ./IsPrimeWrapper.exe <Number> <Arguments>");
                break;
            default:
                int number = Convert.ToInt32(args[0]);
                
                if(IsPrime(number))
                    Console.WriteLine(number + " is a prime number");
                else
                    Console.WriteLine(number + " is not a prime number");
                break;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Error: No arguments provided.");
        Console.WriteLine("Please provide an argument. Use --help for more information.");
    }
}
}
