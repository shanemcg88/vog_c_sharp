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

        public override string MenuTitle { get { return _menuTitle; } }
        public override int MaxMenu { get { return _maxMenu; } }
        public override int MinMenu { get { return _minMenu; } }
        public override string MenuOptions { get { return _menuOptions; } }

    }
}
