using C_Sharp_Assignment.MainMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment.Sections
{
    class IfStatements : MenuModel
    {
        private string _menuTitle = "If Statements";
        private int _maxMenu = 7;
        private int _minMenu = 0;
        private string _menuOptions = "1. Input your age. Display your age and stages" +
            "\n2. Input 2 numbers and show the comparison." +
            "\n3. Input the year and print if it's a leap year." +
            "\n4. Check 'n' is a divisor of 'm' or not." +
            "\n5. Input 2 numbers. Show the maximum and minimum number" +
            "\n6. Input 3 numbers. Display the list of numbers from lowest to highest" +
            "\n7. Find x in function ax2 + bx + c = 0";
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

            }
        }

    }
}
