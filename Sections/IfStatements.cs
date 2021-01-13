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
                case 1:
                    AgeStages();
                    break;
                case 2:
                    NumberComparison();
                    break;
                case 3:
                    LeapYear();
                    break;
                case 4:
                    Divisor();
                    break;
                case 5:
                    MaxAndMinNumbers();
                    break;
                case 6:
                    LowestToHighest();
                    break;
            }
        }

        private void AgeStages()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Input your age. Display your age and stages");
            string ageCategory = string.Empty;
            Console.Write("Please input your age: ");
            int userAge = NumberValidation(Console.ReadLine());

            if (userAge <= 1)
            {
                ageCategory = "Baby";
            }
            else if (userAge >= 2 && userAge <= 3)
            {
                ageCategory = "Toddler";
            }
            else if (userAge >= 4 && userAge <= 12)
            {
                ageCategory = "Kid";
            }
            else if (userAge >= 13 && userAge <= 18)
            {
                ageCategory = "Teenager";
            }
            else if (userAge >= 19 && userAge <= 60)
            {
                ageCategory = "Adult";
            }
            else if (userAge > 60)
            {
                ageCategory = "Senior";
            }

            Console.WriteLine(string.Format("Your age is {0}. You are {1}", userAge, ageCategory));
            SubOptions();
        }

        private void NumberComparison()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("2. Input 2 numbers. Show the comparison of the 2 numbers");
            Console.Write("Enter the first number: ");
            int firstNumber = NumberValidation(Console.ReadLine());
            Console.Write("Enter your second number: ");
            int secondNumber = NumberValidation(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine(string.Format("{0} > {1}", firstNumber, secondNumber));
            } 
            else if (firstNumber < secondNumber)
            {
                Console.WriteLine(string.Format("{0} < {1}", firstNumber, secondNumber));
            }
            else
            {
                Console.WriteLine(string.Format("{0} = {1}", firstNumber, secondNumber));
            }

            SubOptions();
        }

        private void LeapYear()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("3. Input the year and print whether that year is a leap year or not");
            Console.WriteLine("Please enter the year: ");
            int userInput = NumberValidation(Console.ReadLine());

            if ((userInput % 400 == 0) || ((userInput % 4 == 0) && (userInput % 100 != 0)))
            {
                Console.WriteLine(userInput + " IS a leap year");
            }
            else
            {
                Console.WriteLine(userInput + " is NOT a leap year");
            }

            SubOptions();
        }

        private void Divisor()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("4. Check n is divisor of m or not");

            Console.Write("Enter the first number: ");
            int firstNumber = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = NumberValidation(Console.ReadLine());
            if (firstNumber == 0 || secondNumber == 0)
            {
                Console.WriteLine("Please input a number greater than 0");
                Divisor();
            }
            if (firstNumber % secondNumber == 0)
            {
                Console.WriteLine(firstNumber + " is a divisor of " + secondNumber);
            }
            else
            {
                Console.WriteLine(firstNumber + " is NOT a divisor of " + secondNumber);
            }

            SubOptions();
        }

        private void MaxAndMinNumbers()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("5. Input 2 numbers. Show the maximum and minimum number");

            Console.Write("Enter the first number: ");
            int firstNumber = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = NumberValidation(Console.ReadLine());

            if (firstNumber > secondNumber)
            {
                Console.WriteLine("The maximum number is " + firstNumber);
                Console.WriteLine("The minimum number is " + secondNumber);
            }
            else
            {
                Console.WriteLine("The maximum number is " + secondNumber);
                Console.WriteLine("The minimum number is " + firstNumber);
            }

            SubOptions();
        }

        private void LowestToHighest()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("6. Input 3 numbers. Display the list of numbers from lowest to highest");
            int highest=0;
            int middle=0;
            int lowest=0;
            Console.Write("Enter the first number: ");
            int firstNumber = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int secondNumber = NumberValidation(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int thirdNumber = NumberValidation(Console.ReadLine());

            if (firstNumber > secondNumber && firstNumber > thirdNumber)
            {
                highest = firstNumber;
                if (secondNumber > thirdNumber)
                {
                    middle = secondNumber;
                    lowest = thirdNumber;
                }
                else
                {
                    middle = thirdNumber;
                    lowest = secondNumber;
                }   
            }
            else if (secondNumber > firstNumber && secondNumber > thirdNumber)
            {
                    highest = secondNumber;

                if (firstNumber > thirdNumber)
                {
                    middle = firstNumber;
                    lowest = thirdNumber;
                }
                else
                {
                    middle = thirdNumber;
                    lowest = firstNumber;
                }

            }
            else if (thirdNumber > firstNumber && thirdNumber > secondNumber)
            {
                Console.WriteLine("3-1");
                highest = thirdNumber;

                if (secondNumber > firstNumber)
                {
                    Console.WriteLine("3-2");
                    middle = secondNumber;
                    lowest = firstNumber;
                }
                else
                {
                    Console.WriteLine("3-3");
                    middle = firstNumber;
                    lowest = secondNumber;
                }
            }

            Console.WriteLine(string.Format("{0} {1} {2}", lowest, middle, highest));

            SubOptions();
        }

    }
}
