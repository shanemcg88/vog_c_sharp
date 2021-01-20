﻿using C_Sharp_Assignment.Sections;
using System;

namespace C_Sharp_Assignment.MainMenu
{
    class Menu : MenuModel
    {
        private string _menuTitle = "Main Menu";
        private int _maxMenu = 7;
        private int _minMenu = 0;
        private string _menuOptions = "1. Operators | 2. If Statements | 3. Switch Case | 4. Loops (1-10) |" +
                              "\n5. Loops (11-20) | 6. Array";
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
                case 3:
                    Console.Clear();
                    SwitchCase switchCase = new SwitchCase();
                    switchCase.MenuSelection();
                    break;
                case 4:
                    Console.Clear();
                    Loops1 loops1 = new Loops1();
                    loops1.MenuSelection();
                    break;
                case 5:
                    Console.Clear();
                    Loops2 loops2 = new Loops2();
                    loops2.MenuSelection();
                    break;
                case 6:
                    Console.Clear();
                    Arrays1 arrays1 = new Arrays1();
                    arrays1.MenuSelection();
                    break;
                default:
                    MenuSelection();
                    break;
            }
        }       
    }
}
