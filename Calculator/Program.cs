using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Karro's calculator!");

            while (true) 
            {
                int num1;
                int num2;
                string answer;
                int result = 0;

                Console.WriteLine("Enter your first number: ");
                num1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter your second number: ");
                num2 = Convert.ToInt32(Console.ReadLine());

                while (true) 
                {
                    Console.WriteLine("What kind of operation would you like to do?");
                    Console.WriteLine("Type 'a' for addition, 's' for subtraction, 'm' for multiplication or 'd' for division");

                    answer = Console.ReadLine();

                    if (answer == "a")
                    {
                        result = num1 + num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    }
                    else if (answer == "s")
                    {
                        result = num1 - num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    }
                    else if (answer == "m")
                    {
                        result = num1 * num2;
                        Console.WriteLine("The result is: " + result);
                        break;
                    }
                    else if (answer == "d")
                    {
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                            Console.WriteLine("The result is: " + result);
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Division by 0 is not allowed! Please enter new numbers.");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid operation, please try again.");
                    }
                }

                Console.WriteLine("Would you like to perform another calculation? Press down any key if yes otherwise write no");
                string continueAnswer = Console.ReadLine().ToLower();

                if (continueAnswer == "no")
                {
                    Console.WriteLine("Thank you for using Karro's calculator!");
                    break;
                }
            }
        }
    }
}

