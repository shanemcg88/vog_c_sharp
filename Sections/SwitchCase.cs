using C_Sharp_Assignment.MainMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment.Sections
{
    class SwitchCase : MenuModel
    {
        private string _menuTitle = "Switch Case";
        private int _maxMenu = 2;
        private int _minMenu = 0;
        private string _menuOptions = "1. Input day number in integer and display name of day." +
            "\n2. Input the month number and display month name.";
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
                    DayOfTheWeek();
                    break;
                case 2:
                    MonthOfYear();
                    break;
            }
        }

        private void DayOfTheWeek()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Input the day number and display name of day");
            Console.Write("Input day number: ");
            int dayNumber = NumberValidation(Console.ReadLine());

            switch (dayNumber)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Not in range");
                    break;
            }

            SubOptions(_menuNumber);
        }

        private void MonthOfYear()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("2. Input the month number and display month name.");
            Console.Write("Input the month number: ");
            int monthNumber = NumberValidation(Console.ReadLine());

            switch (monthNumber)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                case 7:
                    Console.WriteLine("July");
                    break;
                case 8:
                    Console.WriteLine("August");
                    break;
                case 9:
                    Console.WriteLine("September");
                    break;
                case 10:
                    Console.WriteLine("October");
                    break;
                case 11:
                    Console.WriteLine("November");
                    break;
                case 12:
                    Console.WriteLine("December");
                    break;
                default:
                    Console.WriteLine("Out of range");
                    break;
            }
            SubOptions(_menuNumber);
        }

    }
}
