using C_Sharp_Assignment.MainMenu;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace C_Sharp_Assignment.Sections
{
    class Loops1 : MenuModel
    {
        private string _menuTitle = "Loops pt. 1";
        private int _maxMenu = 15;
        private int _minMenu = 0;
        private string _menuOptions = "1. Input n, n is  natural number, display the list of number from 0 to n" +
            "\n2. Input n, display the multiplication table of n";
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


    }
}
