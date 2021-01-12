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
        private bool _isNested = false;

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
                case 1:
                    Console.Clear();
                    Operators operators = new Operators();
                    operators.MenuSelection();
                    break;
                case 2:
                    Console.Clear();
                    IfStatements ifStatements = new IfStatements();
                    ifStatements.MenuSelection();
                    break;
                default:
                    MenuSelection();
                    break;
            }
        }       
    }
}
