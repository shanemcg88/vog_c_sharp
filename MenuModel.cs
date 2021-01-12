using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment
{
    public abstract class MenuModel
    {
        public abstract string MenuTitle { get; }
        public abstract int MaxMenu { get; }
        public abstract int MinMenu { get; }
        public abstract string MenuOptions { get; }
        public bool IsNested { get; }

        public int menuSectionChoice;

        public void MenuSelection()
        {
            MenuText();
            MenuValidation();
            MenuSections(menuSectionChoice);
        }

        private void MenuText()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine(MenuTitle);
            Console.WriteLine("-------------------------");
            Console.WriteLine(MenuOptions);
            Console.WriteLine("-------------------------");
            Console.WriteLine("0. Exit Program");
            Console.WriteLine("-------------------------");

            Console.Write("Select option #: ");
        }

        private int MenuValidation()
        {
            int menuNumber;
            bool isNumber = Int32.TryParse(Console.ReadLine(), out menuNumber);

            if (isNumber == false || menuNumber > MaxMenu || menuNumber < MinMenu)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("Please enter a valid number from the menu");
                Console.WriteLine("-------------------------");
                MenuSelection();
            }
            else
            {
                return menuSectionChoice = menuNumber;
            }
            return menuNumber;
        }

        public virtual void MenuSections(int menuNumber)
        {

        }
    }
}
