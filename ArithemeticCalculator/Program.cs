using System;

namespace ArithemeticCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            int value1;
            int value2;
            char cancel = 'Y';

            while (cancel== 'Y')
            {
                if (cancel == 'Y')
                {
                    Console.WriteLine("Enter Choice");
                    choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter value 1");
                            value1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter value 2");
                            value2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("The Result is " + Addition(value1, value2));

                            Console.WriteLine("Do you want to continue again (Y/N)?");
                            cancel = Convert.ToChar(Console.ReadLine());
                            break;

                        case 2:
                            Console.WriteLine("Enter value 1");
                            value1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter value 2");
                            value2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("The Result is " + Subtraction(value1, value2));
                            break;

                        case 3:
                            Console.WriteLine("Enter value 1");
                            value1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter value 2");
                            value2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("The Result is " + Multiplication(value1, value2));
                            break;

                        case 4:
                            Console.WriteLine("Enter value 1");
                            value1 = int.Parse(Console.ReadLine());

                            Console.WriteLine("Enter value 2");
                            value2 = int.Parse(Console.ReadLine());

                            Console.WriteLine("The Result is " + Division(value1, value2));
                            break;
                    }
                }

                else
                {
                    break;
                }
            }
            

        }

        static int Addition(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Subtraction(int number1, int number2)
        {
            return number1 - number2;
        }

        static int Multiplication(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Division(int number1, int number2)
        {
            return number1 / number2;
        }
    }
}
