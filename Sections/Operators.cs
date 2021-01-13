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
                    DisplayResultOfTwoNumbers();
                    break;
                case 2:
                    DisplayFullName();
                    break;
                case 3:
                    ConvertCelsius();
                    break;
                default:
                    MenuSelection();
                    break;
            }
        }

        private void DisplayResultOfTwoNumbers()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Input 2 numbers. Display the result of the operator");
            int num1;
            int num2;
            Console.Write("Enter the first number: ");
            num1 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            num2 = NumberValidation(Console.ReadLine());

            float convertedNum1 = (float)num1;
            float convertedNum2 = (float)num2;

            Console.WriteLine(string.Format("{0} + {1} = {2}", convertedNum1, convertedNum2, convertedNum1 + convertedNum2));
            Console.WriteLine(string.Format("{0} - {1} = {2}", convertedNum1, convertedNum2, convertedNum1 - convertedNum2));
            Console.WriteLine(string.Format("{0} * {1} = {2}", convertedNum1, convertedNum2, convertedNum1 * convertedNum2));
            Console.WriteLine(string.Format("{0} / {1} = {2}", convertedNum1, convertedNum2, convertedNum1 / convertedNum2));
            Console.WriteLine(string.Format("{0} % {1} = {2}", convertedNum1, convertedNum2, convertedNum1 % convertedNum2));

            SubOptions(_menuNumber);
        }

        private void DisplayFullName()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("2. Input first name and last name. Display the full name");

            Console.Write("Please enter the first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Please enter the last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine(string.Format("The full name is: {0} {1}", firstName, lastName));
            SubOptions(_menuNumber);
        }

        private void ConvertCelsius()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("Convert Celsius to Fahrenheit");
            Console.Write("Input Celsius: ");
            int userInput = NumberValidation(Console.ReadLine());
            int celsiusToFahrenheit = (userInput * 9 / 5) + 32;

            Console.WriteLine(string.Format("{0}C is {1}F", userInput, celsiusToFahrenheit));
            SubOptions(_menuNumber);
        }
    }
}
