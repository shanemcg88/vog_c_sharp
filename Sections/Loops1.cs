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
            "\n4. Input n, n is natural number, calculate the average all numbers from 1 to n";
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
            }
        }

        private void ZeroToN()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Input n, n is  natural number, display the list of number from 0 to n");
            Console.WriteLine("Enter a number for n: ");
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
            Console.WriteLine("Enter a number for n: ");
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
            Console.WriteLine("Enter a number for n: ");
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
            Console.WriteLine("Enter a number for n: ");
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


    }
}
