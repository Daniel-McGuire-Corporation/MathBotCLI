// DMC CS Script - MathBot CLI v3.1.2 - First Made By Daniel McGuire on 11/08/2021
// Credit: Daniel McGuire, Andrew "The Coder" M.
// Copyright 2021 - 2023 Daniel McGuire Corporation
// All Rights Reserved.
// Available under GNU GP v3.0.0 License 
using System;

class MathBotCLI
{
    //Start Math Stuff
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
        //End Math Stuff
    }

    static void Main(string[] args)
    {
        if (args.Length > 0)
        {
            switch(args[0])
            {
                // About Details
                case "--about":
                case "-info":
                case "-a":
                case "/about":
                    Console.Clear();
                    Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                    Console.WriteLine("Copyright (C) 2023 Daniel McGuire Corporation");
                    Console.WriteLine("MathBot CLI Version 3.1.2");
                    Console.WriteLine();
                    Console.WriteLine("This Application was Written in C# by Daniel McGuire.");
                    Console.WriteLine("More Credits Available using -c switch.");
                    Console.WriteLine();
                    Console.WriteLine("This software is under GNU GP v3 License.");
                    Console.WriteLine("More info will be here in 2024");
                    break;
                // Help Details
                case "--help":
                case "-h":
                case "/?":
                case "/help":
                    Console.Clear();
                    Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                    Console.WriteLine("MathBot CLI Version 3.1.2");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Usage:");
                    Console.WriteLine("  --about, -info, -a: Show About info");
                    Console.WriteLine("  --credits, -c: Credits");
                    Console.WriteLine("  --help, -h: Show help");
                    Console.WriteLine("  --prime <number>: Check if a number is a prime number");
                    Console.WriteLine("  --addition, -add: Add Numbers Together");
                    Console.WriteLine("  --subtraction, -subtract: Subtract Numbers");
                    Console.WriteLine("  --multiplication -multiply: Multiply Numbers");
                    Console.WriteLine("  --division, -divide: Divide Numbers");
                    Console.WriteLine("  --upcoming: Upcoming Features");
                    Console.WriteLine();
                    Console.WriteLine("(Legacy Arguments (e.g. /?) exist.)");
                    Console.WriteLine();
                    Console.WriteLine("Example:    $ MathBotCLI <--operation> <number1> <number2>");
                    break;
                // Upcoming
                case "--upcoming":
                    Console.Clear();
                    Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                    Console.WriteLine("Copyright (C) 2023 Daniel McGuire Corporation");
                    Console.WriteLine("MathBot CLI Version 3.1.2");
                    Console.WriteLine();
                    Console.WriteLine("===================");
                    Console.WriteLine("=Upcoming Features=");
                    Console.WriteLine("===================");
                    Console.WriteLine();
                    Console.WriteLine("This page will be enabled in the 4.0.0 update.");
                    break;
                // Credits
                case "--credits":
                case "-c":
                    Console.Clear();
                    Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                    Console.WriteLine("Copyright (C) 2023 Daniel McGuire Corporation");
                    Console.WriteLine("MathBot CLI Version 3.1.2");
                    Console.WriteLine();
                    Console.WriteLine("Main Coder: Daniel McGuire");
                    Console.WriteLine("2nd Coder / Math Expert: Andrew M.");
                    Console.WriteLine();
                    Console.WriteLine("Special Thanks to Microsoft for Making .NET and Visual Studio and VS Code!");
                    Console.WriteLine("RIP Visual Studio for macOS (One of the program used for this project).");
                    break;
                //Prime 
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
                //Legacy Arguments for Prime
                case "/prime":
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
                        Console.WriteLine("Please provide a number after /prime");
                    }
                    break;
                //Addition
                case "--addition":
                case "-add":
                case "/add":
                    if (args.Length > 2)
                    {
                        int number1 = Convert.ToInt32(args[1]);
                        int number2 = Convert.ToInt32(args[2]);
                        Console.WriteLine("The sum is " + (number1 + number2));
                    }
                    else
                    {
                        Console.WriteLine("Please provide two numbers after --addition");
                    }
                    break;
                //Subtraction
                case "--subtraction":
                case "-subtract":
                case "/subtract":
                    if (args.Length > 2)
                    {
                        int number1 = Convert.ToInt32(args[1]);
                        int number2 = Convert.ToInt32(args[2]);
                        Console.WriteLine("The difference is " + (number1 - number2));
                    }
                    else
                    {
                        Console.WriteLine("Please provide two numbers after --subtraction");
                    }
                    break;
                //Multiplication
                case "--multiplication":
                case "-multiply":
                case "/multiply":
                    if (args.Length > 2)
                    {
                        int number1 = Convert.ToInt32(args[1]);
                        int number2 = Convert.ToInt32(args[2]);
                        Console.WriteLine("The product is " + (number1 * number2));
                    }
                    else
                    {
                        Console.WriteLine("Please provide two numbers after --multiplication");
                    }
                    break;
                //Division
                case "--division":
                case "-divide":
                case "/divide":
                    if (args.Length > 2)
                    {       
                        int number1 = Convert.ToInt32(args[1]);
                        int number2 = Convert.ToInt32(args[2]);
                        if (number2 != 0)
                            Console.WriteLine("The quotient is " + ((double)number1 / number2));
                        else
                            Console.WriteLine("Cannot divide by zero");
                    }
                    else
                    {
                        Console.WriteLine("Please provide two numbers after --division");
                    }
                    break;
                //ERROR
                default:
                    Console.Clear();
                    Console.WriteLine("Please specify a valid argument. Use -h for more information.");
                    break;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Please specify a valid argument. Use -h for more information.");
        }
    }
}
