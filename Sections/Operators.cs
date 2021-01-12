using System;
using C_Sharp_Assignment.MainMenu;

namespace C_Sharp_Assignment.Sections
{
    class Operators : MenuModel
    {
        private string _menuTitle = "Operators";
        private int _maxMenu = 3;
        private int _minMenu = 0;
        private string _menuOptions = "1. Input 2 numbers. Display the result" +
            "\n2. Input first name and last name. Display the full name" +
            "\n3. Convert Celsius to Fahrenheit";
        private bool _isNested = true;

        public override string MenuTitle { get { return _menuTitle; } }
        public override int MaxMenu { get { return _maxMenu; } }
        public override int MinMenu { get { return _minMenu; } }
        public override string MenuOptions { get { return _menuOptions; } }
        public override bool IsNested { get { return _isNested; } }

        public override void MenuSections(int menuNumber)
        {
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
                    DisplayResultOfTwoNumbers();
                    break;
            }
        }

        public void DisplayResultOfTwoNumbers()
        {
            int num1;
            int num2;
            bool isNumber;
            Console.Clear();
            Console.Write("Enter the first number: ");
            var userInput1 = Console.ReadLine();
            isNumber = Int32.TryParse(userInput1, out num1);
            Console.Write("Enter the second number: ");
            var userInput2 = Console.ReadLine();
            isNumber = Int32.TryParse(userInput2, out num2);

            Console.WriteLine("NUM 1= " + num1 + "NUM2 = " + num2);

        }

    }
}
