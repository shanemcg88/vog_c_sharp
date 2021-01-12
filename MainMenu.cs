using C_Sharp_Assignment.Sections;
using System;

namespace C_Sharp_Assignment.MainMenu
{
    class Menu : MenuModel
    {
        private string _menuTitle = "Main Menu";
        private int _maxMenu = 7;
        private int _minMenu = 0;
        private string _menuOptions = "1. Operators | 2. If Statements | 3. Switch Case | 4. Loop |" +
                              "\n5. Array | 6. Function | 7. Class";

        public override string MenuTitle { get { return _menuTitle; } }
        public override int MaxMenu { get { return _maxMenu; } }
        public override int MinMenu { get { return _minMenu; } }
        public override string MenuOptions { get { return _menuOptions; } }

        public override void MenuSections(int menuNumber)
        {
            switch (menuNumber)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    Console.Clear();
                    Operators operators = new Operators();
                    operators.MenuSelection();
                    break;
            }
        }
        //protected override void MenuText()
        //{
        //    Console.WriteLine("-------------------------");
        //    Console.WriteLine("Main Menu");
        //    Console.WriteLine("-------------------------");
        //    Console.WriteLine("1. Operators | 2. If Statements | 3. Switch Case | 4. Loop |" +
        //                      "\n 5. Array | 6. Function | 7. Class");
        //    Console.WriteLine("-------------------------");
        //    Console.WriteLine("0. Exit");
        //    Console.WriteLine("-------------------------");

        //    Console.Write("Select option #: ");
        //}
        //protected override void MenuValidation()
        //{
            //int menuNumber;
            //bool isNumber = Int32.TryParse(Console.ReadLine(), out menuNumber);

            //if (isNumber == false || menuNumber > _maxMenu || menuNumber < _minMenu)
            //{
            //    Console.Clear();
            //    Console.WriteLine("-------------------------");
            //    Console.WriteLine("Please enter a valid number from the menu");
            //    Console.WriteLine("-------------------------");
            //    MenuSelection();
            //}
            //else
            //{
            //    MenuSections(menuNumber);
            //}

        
    }
}
