// DMC CS Script - MathBot CLI v3.0.1 - First Made By Daniel McGuire on 11/08/2021
// Credit: Myself, GitHub Copilot, ChatGPT.
// Copyright 2021 - 2023 Daniel McGuire Corporation
//              All Rights Reserved.
// Compiled Using dotnet on September 30th, 2023
// **Above Info May Be Incorrect If Cloned From GitHub Repo**
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
                    Console.WriteLine("Copyright (C) 2023 Daniel McGuire Corporation");
                    Console.WriteLine("This software is under GNU GP v3 License");
                    Console.WriteLine("Please visit https://www.daniellmcguirecorporation.ml for more info");
                    break;
                case "--help":
                case "-h":
                    Console.Clear();
                    Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                    Console.WriteLine("MathBot CLI Version 3.0.1");
                    Console.WriteLine();
                    Console.WriteLine("  MORE ARGUMENTS COMING SOON");
                    Console.WriteLine();
                    Console.WriteLine("Usage:");
                    Console.WriteLine("  --credits, -c: Show credits");
                    Console.WriteLine("  --help, -h: Show help");
                    Console.WriteLine("  --prime <number>: Check if a number is a prime number");
                    Console.WriteLine();
                    Console.WriteLine("Example: ./MathBotCLI.exe --prime <Number>");
                    break;
                case "--prime":
                    if (args.Length > 1)
                    {
                        int number = Convert.ToInt32(args[1]);
                        if(IsPrime(number))
                            Console.WriteLine(number + " is a prime number.");
                        else
                            Console.WriteLine(number + " is not a prime number.");
                    }
                    else
                    {
                        Console.WriteLine("Please provide a number after --prime");
                    }
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Error: No Arguments Specified.");
                    Console.WriteLine("Please specify an argument. Use --help for more information.");
                    break;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Error: No Numbers or Arguments Specified.");
            Console.WriteLine("Please specify an argument. Use --help for more information.");
        }
    }
}
