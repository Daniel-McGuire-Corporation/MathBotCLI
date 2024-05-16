// DMC CS Script - MathBot CLI v3.4.0.0.5064 - First Made By Daniel McGuire on 11/08/2021
// Credit: Daniel McGuire, Andrew "The Coder" M.
// Copyright 2021 - 2024 Daniel McGuire Corporation
// All Rights Reserved.
// Available under MIT License 
using System;
using System.Diagnostics;

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
                case "--random":
                case "-random":
                    if (args.Length > 2 && long.TryParse(args[1], out long length) && int.TryParse(args[2], out int count))
                    {
                        if (length <= 0 || count <= 0)
                        {
                            Console.WriteLine("Please provide positive numbers greater than zero for the length and count.");
                        }
                        else
                        {
                            if (length * count > 99999)
                            {
                                Console.WriteLine("This attempt was stopped because this could quickly fill up memory");
                                Console.WriteLine("(The max amount of total numbers is 99999)");
                            }
                            else
                            {
                                Random rand = new Random();
                                for (int j = 0; j < count; j++)
                                {
                                    string randomNumber = "";
                                    for (long i = 0; i < length; i++)
                                    {
                                        randomNumber += rand.Next(0, 10);
                                    }
                                    Console.WriteLine("Random Number " + (j + 1) + ": " + randomNumber);
                                }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please provide valid length and count for the random numbers.");
                    }
                    break;
                // About Details
                case "--about":
                case "-info":
                case "-a":
                case "/about":
                    Console.Clear();
                    Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                    Console.WriteLine("Copyright (C) 2024 Daniel McGuire Corporation");
                    Console.WriteLine("MathBot CLI Version 24H2 Build 3.4.0.0.5064");
                    Console.WriteLine();
                    Console.WriteLine("This Application was Written in C# by Daniel McGuire.");
                    Console.WriteLine("More Credits Available using -c switch.");
                    Console.WriteLine();
                    Console.WriteLine("This software is under MIT License.");
                    break;
                // Help Details
                case "--help":
                case "-h":
                case "/?":
                case "/help":
                    Console.Clear();
                    Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                    Console.WriteLine("MathBot CLI Version 24H2");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Usage:");
                    Console.WriteLine("  --about, -info, -a: Show About info");
                    Console.WriteLine("  --credits, -c: Credits");
                    Console.WriteLine("  --help, -h: Show help");
                    Console.WriteLine("  --prime: Check if a number is a prime number");
                    Console.WriteLine("  --addition, -add: Add Numbers Together");
                    Console.WriteLine("  --subtraction, -subtract: Subtract Numbers");
                    Console.WriteLine("  --multiplication -multiply: Multiply Numbers");
                    Console.WriteLine("  --division, -divide: Divide Numbers");
                    Console.WriteLine("  --random, -random: Generate a Random Number with given length");
                    Console.WriteLine("     <Length of number> <Amount of numbers>");
                    Console.WriteLine();
                    Console.WriteLine("(Legacy Arguments (e.g. /?) exist.)");
                    Console.WriteLine();
                    Console.WriteLine("Example: MathBotCLI <--operation> <number1> <number2>");
                    break;
                // Upcoming
                case "--upcoming":
                    Console.WriteLine("Please refer to the GitHub Readme.");
                    break;
                // Credits
                case "--credits":
                case "-c":
                    Console.Clear();
                    Console.WriteLine("Daniel McGuire Corporation Tools (R)");
                    Console.WriteLine("Copyright (C) 2024 Daniel McGuire Corporation");
                    Console.WriteLine("MathBot CLI Version 24H2"); 
                    Console.WriteLine();
                    Console.WriteLine("Logic Expert / Coder: Daniel McGuire");
                    Console.WriteLine("Designer / Math Expert: Andrew M.");
                    Console.WriteLine("Wordsmith (grammar and word expert): John Belanger");
                    Console.WriteLine("Error Handling: Ava Johnston");
                    Console.WriteLine("Error Helper: Windows Copilot and ChatGPT");
                    Console.WriteLine();
                    Console.WriteLine("Made at Daniel McGuire Inc of England and Canada");
                    Console.WriteLine("Thank you for using MathBotCLI");
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
