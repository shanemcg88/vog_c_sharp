using C_Sharp_Assignment.MainMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment.Sections
{
    class Loops2 : MenuModel
    {
        private string _menuTitle = "Loops pt. 2";
        private int _maxMenu = 10;
        private int _minMenu = 0;
        private string _menuOptions = "1. Input n row and m column, display a rectangle." +
            "\n2. Input n row and m column, display the border rectangle asterisk." +
            "\n3. Input n, display the right angle triangle asterisk" +
            "\n4. Input n, display the left angle triangle asterisk" +
            "\n5. Input n, display the pine asterisk";
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
                    RectangleAsterisk();
                    break;
                case 2:
                    BorderRectAsterisk();
                    break;
                case 3:
                    RightAngleTriangleAsterisk();
                    break;
                case 4:
                    LeftAngleTriangleAsterisk();
                    break;
                case 5:
                    PineAsterisk();
                    break;
                default:
                    MenuSelection();
                    break;
            }

        }

        private void RectangleAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Input n row and m column, display a rectangle.");
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

        private void BorderRectAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("2. Input n row and m column, display the border rectangle asterisk.");
            Console.Write("Enter a number for rows: ");
            int rows = NumberValidation(Console.ReadLine());
            Console.Write("Enter a number for columns: ");
            int cols = NumberValidation(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                for (int x = 1; x <= cols; x++)
                {
                    if (i == 1 || i == rows || x == 1 || x == cols)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            SubOptions(_menuNumber);
        }

        private void RightAngleTriangleAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("3. Input n, display the right angle triangle asterisk");
            Console.Write("Enter a number for n: ");
            int userInput = NumberValidation(Console.ReadLine());

            for(int row = 1; row <= userInput; row++)
            {
                for(int col = 1; col <= userInput; col++)
                {
                    if (col <= row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            SubOptions(_menuNumber);
        }

        private void LeftAngleTriangleAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("4. Input n, display the left angle triangle asterisk");
            Console.Write("Enter a number for n: ");
            int userInput = NumberValidation(Console.ReadLine());

            for (int row = 1; row <= userInput; row++)
            {
                for (int col = userInput; col != 0; col--)
                {
                    if (col >= row)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }                        
                }
                Console.WriteLine();
            }

            SubOptions(_menuNumber);
        }

        private void PineAsterisk()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("5. Input n, display the pine asterisk");
            Console.Write("Enter a number for n: ");
            int userInput = NumberValidation(Console.ReadLine());

            for (int row = 0; row <= userInput; row++)
            {
                
                for (int col = 1; col <= userInput; col++)
                {
                    //if (col == (1+userInput) / 2 && row == 1)
                    //{ 
                    //    Console.Write("*");
                    //}
                    if (col == ((1 + userInput) / 2)-row || col == ((1 + userInput) / 2)+row)
                    {
                        Console.Write("*");
                    }
                    else if (col % 2 == 0)
                    {
                        Console.Write(" ");
                    }
                    else if (row == userInput)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

            SubOptions(_menuNumber);
        }

    }
}
