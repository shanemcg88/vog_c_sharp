using C_Sharp_Assignment.MainMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment.Sections
{
    class Loops2 : MenuModel
    {
        private string _menuTitle = "Loops pt. 2";
        private int _maxMenu = 20;
        private int _minMenu = 11;
        private string _menuOptions = "11. Input n row and m column, display a rectangle.";
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
                case 11:
                    RectangleAsterisk();
                    break;
            }

        }

        private void RectangleAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("11. Input n row and m column, display a rectangle.");
            Console.Write("Enter a number for rows: ");
            int rows = NumberValidation(Console.ReadLine());
            Console.Write("Enter a number for columns: ");
            int cols = NumberValidation(Console.ReadLine());

            for(int i = 1; i <= rows; i++)
            {
                for(int x = 1; x <= cols; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            SubOptions(_menuNumber);
        }


    }
}
