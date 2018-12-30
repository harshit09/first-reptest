using System;
using System.Linq;

namespace ConsoleApplication
{
    internal class Program
    {
        public class ExerciseConditional
        {
            public static void Exercise1()
            {
                Console.WriteLine("Input a number between 1 to 10:");
                var number = Convert.ToInt32(Console.ReadLine());
                var res1 = (number >= 1 && number <= 10) ? "Valid\n" : "Invalid\n";
                Console.WriteLine(res1);
            }

            public static void Exercise2()
            {
                Console.WriteLine("Enter two numbers for comparision:");
                var number1 = Convert.ToInt32(Console.ReadLine());
                var number2 = Convert.ToInt32(Console.ReadLine());
                var res2 = (number1 > number2) ? "Bigger number between " + number1 + " and " + number2 + " is " + number1 + "\n" : "Bigger number between " + number1 + " and " + number2 + " is " + number2 + "\n";
                Console.WriteLine(res2);
            }

            public static void Exercise3()
            {
                Console.WriteLine("Enter width of Image:");
                var width = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter height of Image:");
                var height = Convert.ToInt32(Console.ReadLine());
                var res3 = (height > width) ? "Image is a Portrait\n" : "Image is a Landscape\n";
                Console.WriteLine(res3);
            }

            public static void Exercise4()
            {
                Console.WriteLine("Enter speed limit kph:");
                var limit = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter car speed in kph:");
                var speed = Convert.ToInt32(Console.ReadLine());
                if (speed < limit)
                {
                    Console.WriteLine("Your speed is OK\n");
                }
                else if (speed > limit)
                {
                    var overSpeed = speed - limit;
                    var demeritPoints = overSpeed / 5;
                    if (demeritPoints >= 1 && demeritPoints < 12)
                    {
                        Console.WriteLine("The demerit points awarded to you for over-speeding are: " + demeritPoints + "\n");
                    }
                    else if (demeritPoints >= 12)
                    {
                        Console.WriteLine("License Suspend for heavy over-speeding\n");
                    }
                }
            }

            public static void Exercise5()
            {
                Console.WriteLine("Counting numbers between 1 and 100 divisible by 3\n");
                var count = 0;
                for (var i = 1; i <= 100; i++)
                {
                    var checkRem = i % 3;
                    if (checkRem == 0)
                        count++;
                }
                Console.WriteLine("Count: " + count + "\n");
            }

            public static void Exercise6()
            {
                while (true)
                {
                    Console.WriteLine("Enter a number.\n");
                    var userInput = Console.ReadLine();
                    if (userInput == "ok")
                    {
                        Environment.Exit(0);
                    }
                    else
                    {
                        var sumInputs = 0;
                        sumInputs += Convert.ToInt32(userInput);
                        Console.WriteLine("Sum Total: " + sumInputs + "\n");
                    }
                }
                // ReSharper disable once FunctionNeverReturns
            }

            public static void Exercise7()
            {
                Console.WriteLine("Enter a number:\n");
                var num = Convert.ToInt32(Console.ReadLine());
                if(num <= 0) {
                    Console.WriteLine("Please provide numbers greater than 0\n");
                }
                else
                {
                    var fact = 1;
                    for (var i = num; i > 0; i--)
                    {
                        fact = i * fact;
                    }
                    if (num % 1 == 0)
                    {
                        Console.WriteLine(num + "! = " + fact + "\n");
                    }
                }
            }

            public static void Exercise8()
            {
                var rand = new Random();
                var randomNumber = rand.Next(1, 10);
                Console.WriteLine("Guess the random number between 1 and 10.\n");
                Console.WriteLine("Random Number = " + randomNumber + "\n");
                for (var i = 0; i <= 3; i++) {
                    var guessNumber = Convert.ToInt32(Console.ReadLine());
                    if (guessNumber == randomNumber)
                    {
                        Console.WriteLine("Congratulations!!! You Won.\n");
                        Environment.Exit(0);
                    }
                    else
                    {
                        switch (i)
                        {
                            case 0:
                                Console.WriteLine("Please try again. 2 chances remaining.\n");
                                break;
                            case 1:
                                Console.WriteLine("Please try again. 1 chances remaining.\n");
                                break;
                            default:
                                Console.WriteLine("Sorry!!! You Lost\n");
                                Environment.Exit(0);
                                break;
                        }
                    }
                }
            }

            public static void Exercise9()
            {
                Console.WriteLine("Write a series of numbers separated by comma. Ex: 3,6,12,14,2");
                var series = Console.ReadLine();
                if (series == null) return;
                var numbers = series.Split(',');
                var max = Convert.ToInt32(numbers[0]);
                max = numbers.Select(number => Convert.ToInt32(number)).Concat(new[] {max}).Max();
                Console.WriteLine("Max number is: " + max + "\n");
            }

            public static void Exercise10()
            {
                
            }
        }

        private static void Main()
        {
            Console.WriteLine("Which exercise do you want to run of the following:\n1. Validate number between 1 to 10.\n2. Find the larger number.\n3. Find Image Layout.\n4. Verify car speed.\n5. Find count of numbers between 1 and 100 divisible by 3 without remainder.\nType 0 to exit from Console Application.\n");
            while (true)
            {
                try
                {
                    var selection = Convert.ToInt32(Console.ReadLine());
                    if (selection == 0)
                        break;
                    else switch (selection)
                    {
                        case 1:
                            ExerciseConditional.Exercise1();
                            break;
                        case 2:
                            ExerciseConditional.Exercise2();
                            break;
                        case 3:
                            ExerciseConditional.Exercise3();
                            break;
                        case 4:
                            ExerciseConditional.Exercise4();
                            break;
                        case 5:
                            ExerciseConditional.Exercise5();
                            break;
                        case 6:
                            ExerciseConditional.Exercise6();
                            break;
                        case 7:
                            ExerciseConditional.Exercise7();
                            break;
                        case 8:
                            ExerciseConditional.Exercise8();
                            break;
                        case 9:
                            ExerciseConditional.Exercise9();
                            break;
                        case 10:
                            ExerciseConditional.Exercise10();
                            break;
                        default:
                            Console.WriteLine("Invalid Input. Input should be between 1-4.\n");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Incorrect format. Please type a number of integer format.");
                }
            }
        }
    }
}