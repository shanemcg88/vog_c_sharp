using C_Sharp_Assignment.MainMenu;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace C_Sharp_Assignment.Sections
{
    class Loops1 : MenuModel
    {
        private string _menuTitle = "Loops pt. 1";
        private int _maxMenu = 15;
        private int _minMenu = 0;
        private string _menuOptions = "1. Input n, n is natural number, display the list of number from 0 to n" +
            "\n2. Input n, display the multiplication table of n" +
            "\n3. Input n, n is natural number, calculate the sum of number from 1 to n" +
            "\n4. Input n, n is natural number, calculate the average all numbers from 1 to n" +
            "\n5. Input n, n is natural number, display the sum of odd numbers from 1 to n" +
            "\n6. **" +
            "\n7. Input n, n is natural number, display all n of divisors from 1 to n" +
            "\n8. Input n, display the squart asterisk with n column and row." +
            "\n9. Input n, display the border square asterisk with n column and row." +
            "\n10. Input n, display the border squart asterisk with n column and row and its diagonal line.";
        private bool _isNested = true;
        private int _menuNumber;

        public override string MenuTitle { get { return _menuTitle; } }
        public override int MaxMenu { get { return _maxMenu; } }
        public override int MinMenu { get { return _minMenu; } }
        public override string MenuOptions { get { return _menuOptions; } }
        public override bool IsNested { get { return _isNested; } }

        public override void MenuSections(int menuNumber)
        {
            _menuNumber = menuNumber;

            switch (menuNumber)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 100:
                    Console.Clear();
                    Menu mainMenu = new Menu();
                    mainMenu.MenuSelection();
                    break;
                case 1:
                    ZeroToN();
                    break;
                case 2:
                    MultiplicationOfN();
                    break;
                case 3:
                    SumOfN();
                    break;
                case 4:
                    AverageOfN();
                    break;
                case 5:
                    SumOfOddN();
                    break;
                case 6:
                    Console.WriteLine("coming soon");
                    SubOptions(_menuNumber);
                    break;
                case 7:
                    DivisorsOfN();
                    break;
                case 8:
                    SquareAsterisk();
                    break;
                case 9:
                    BorderSquareAsterisk();
                    break;
                case 10:
                    DiagonalSquareAsterisk();
                    break;
            }
        }

        private void ZeroToN()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Input n, n is  natural number, display the list of number from 0 to n");
            Console.Write("Enter a number for n: ");
            int userNumber = NumberValidation(Console.ReadLine());

            Console.WriteLine("You entered: " + userNumber);
            for (int x = 0; x <= userNumber; x++)
            {
                Console.Write(x + ", ");
            }

            Console.WriteLine("");
            SubOptions(_menuNumber);
        }

        private void MultiplicationOfN()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("2. Input n, display the multiplication table of n");
            Console.Write("Enter a number for n: ");
            int userNumber = NumberValidation(Console.ReadLine());

            Console.WriteLine("You entered: " + userNumber);
            for (int x = 0; x <= 10; x++)
            {
                Console.WriteLine(string.Format("{0} x {1} = {2}", userNumber, x, userNumber * x));
            }

            SubOptions(_menuNumber);
        }

        private void SumOfN()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("3. Input n, n is  natural number,  calculate the sum of number from 1 to n");
            Console.Write("Enter a number for n: ");
            int userNumber = NumberValidation(Console.ReadLine());

            int total = 0;
            int i = 0;
            Console.WriteLine("You entered: " + userNumber);
            
            while (i != userNumber+1)
            {
                if (i == userNumber)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + " + ");
                }
                total += i;
                i++;
            }

            Console.WriteLine(" = " + total);
            SubOptions(_menuNumber);   
        }

        private void AverageOfN()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("4. Input n, n is natural number, calculate the average all numbers from 1 to n");
            Console.Write("Enter a number for n: ");
            int userNumber = NumberValidation(Console.ReadLine());

            int collection = 0;
            int i = 0;

            Console.Write("(");
            while (i != userNumber+1)
            {
                if (i == userNumber)
                {
                    Console.Write(i);
                }
                else
                {
                    Console.Write(i + " + ");
                }
                collection += i;
                i++;
            }
            Console.Write(")");

            float total = (float)collection / (float)userNumber;

            Console.Write(" / " + userNumber + " = " + total);
            Console.WriteLine("");

            SubOptions(_menuNumber);
        }

        private void SumOfOddN()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("5. Input n, n is natural number, display the sum of odd numbers from 1 to n");
            Console.Write("Enter a number for n: ");
            int userNumber = NumberValidation(Console.ReadLine());

            int total = 0;
            for (int i = 0; i <= userNumber; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                else
                {
                    if (i == userNumber-1 || i == userNumber)
                    {
                        Console.Write(i);
                    }
                    else
                    {
                        Console.Write(i + " + ");
                    }
                    total += i;
                }
            }
            Console.Write(" = " + total);
            Console.WriteLine();

            SubOptions(_menuNumber);
        }

        /////////////////////////////////////////////
        ///# 6 GOES HERE
        /////////////////////////////////////////////
        
        private void DivisorsOfN()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("7. Input n, n is natural number, display all n of divisors from 1 to n");
            Console.Write("Enter a number for n: ");
            int userInput = NumberValidation(Console.ReadLine());

            for(int i = 1; i <= userInput; i++)
            {
                if (userInput % i == 0)
                {
                    Console.Write(i + " ");
                }
            }

            Console.WriteLine();
            SubOptions(_menuNumber);
        }

        private void SquareAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("8. Input n, display the squart asterisk with n column and row.");
            Console.Write("Enter a number for n: ");
            int userInput = NumberValidation(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                for (int x = 1; x <= userInput; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            SubOptions(_menuNumber);   
        }

        private void BorderSquareAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("9. Input n, display the border square asterisk with n column and row.");
            Console.Write("Enter a number for n: ");
            int userInput = NumberValidation(Console.ReadLine());

            for (int i = 1; i <= userInput; i++)
            {
                for (int x = 1; x <= userInput; x++)
                {
                    if (i == 1 || i == userInput || x == 1 || x == userInput)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            SubOptions(_menuNumber);
        }

        private void DiagonalSquareAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Input n, display the border square asterisk with n column and row and its diagonal line.");
            Console.Write("Enter a number for n: ");
            int userInput = NumberValidation(Console.ReadLine());

            for (int row = 1; row <= userInput; row++)
            {
                for (int col = 1; col <= userInput; col++)
                {
                    if (row == 1 || row == userInput || col == 1 || col == userInput)
                    {
                        Console.Write("*");
                        
                    }
                    else if (row == col || row == userInput-col+1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            SubOptions(_menuNumber);
        }




    }
}
