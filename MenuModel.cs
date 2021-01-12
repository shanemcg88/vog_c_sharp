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
        public abstract bool IsNested { get; }

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
            Console.WriteLine(IsNested ? "B. Back" : null);
            Console.WriteLine("0. Exit Program");
            Console.WriteLine("-------------------------");

            Console.Write("Select option #: ");
        }

        private void MenuValidation()
        {
            int menuNumber;
            string userInput = Console.ReadLine();
            bool isNumber = Int32.TryParse(userInput, out menuNumber);

            if (isNumber == false && userInput.ToUpper() != "B" || menuNumber > MaxMenu || menuNumber < MinMenu)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("Please enter a valid number from the menu");
                Console.WriteLine("-------------------------");
                MenuSelection();
            }
            else if (userInput.ToUpper() == "B")
            {
                menuNumber = 100;
                MenuSections(menuNumber);
            }
            else
            {
                MenuSections(menuNumber);
            }
            
        }

        public virtual void MenuSections(int menuNumber)
        {

        }
    }
}
