using C_Sharp_Assignment.MainMenu;
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Sharp_Assignment.Sections
{
    class Arrays1 : MenuModel
    {
        private string _menuTitle = "Arrays pt. 1";
        private int _maxMenu = 5;
        private int _minMenu = 0;
        private string _menuOptions = "1. Input int into array, display all the elements in console" +
            "\n2. Input int into array, sort array, display all the elements in console" + 
            "\n3. Input int into array. Calculate sum of array" +
            "\n4. Input Int array with n element, calculate the sum of even number in array" +
            "\n5. Input Int array with n element, find the max value";
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
                    IntArray();
                    break;
                case 2:
                    SortArray();
                    break;
                case 3:
                    SumArray();
                    break;
                case 4:
                    SumOfEven();
                    break;
                case 5:
                    MaxValueArray();
                    break;
            }
        }

        private void IntArray()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("1. Input int array with n element, display all the elements on console");
            Console.Write("Enter the first number: ");
            int userNumber1 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int userNumber2 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int userNumber3 = NumberValidation(Console.ReadLine());

            int[] arr = { userNumber1, userNumber2, userNumber3 };

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            SubOptions(_menuNumber);
        }

        private void SortArray()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("2. Input int array with n element, sort array, display all the elements in console");
            Console.Write("Enter the first number: ");
            int userNumber1 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int userNumber2 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int userNumber3 = NumberValidation(Console.ReadLine());

            int[] arr = { userNumber1, userNumber2, userNumber3 };
            Array.Sort(arr);

            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            SubOptions(_menuNumber);
        }

        private void SumArray()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("3. Input int into array. Calculate sum of array");
            Console.Write("Enter the first number: ");
            int userNumber1 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int userNumber2 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int userNumber3 = NumberValidation(Console.ReadLine());

            int[] arr = { userNumber1, userNumber2, userNumber3 };
            int sum = 0;

            foreach (int i in arr)
            {
                Console.Write(i + " ");
                sum += i;
            }

            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);

            SubOptions(_menuNumber);
        }

        private void SumOfEven()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("4. Input Int array with n element, calculate the sum of even number in array");
            Console.Write("Enter the first number: ");
            int userNumber1 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int userNumber2 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int userNumber3 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the fourth number: ");
            int userNumber4 = NumberValidation(Console.ReadLine());

            int[] arr = { userNumber1, userNumber2, userNumber3, userNumber4 };
            int sum = 0;

            foreach (int i in arr)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Sum = " + sum);

            SubOptions(_menuNumber);
        }

        private void MaxValueArray()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("5. Input Int array with n element, find the max value");
            Console.Write("Enter the first number: ");
            int userNumber1 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the second number: ");
            int userNumber2 = NumberValidation(Console.ReadLine());
            Console.Write("Enter the third number: ");
            int userNumber3 = NumberValidation(Console.ReadLine());

            int[] arr = { userNumber1, userNumber2, userNumber3 };
            int prevNumber = 0;
            int maxNumber = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == 0)
                {
                    maxNumber = arr[i];
                    prevNumber = arr[i];
                }
                else if (arr[i] > prevNumber && arr[i] > maxNumber)
                {
                    maxNumber = arr[i];
                    prevNumber = arr[i];
                }
                else if (arr[i] < prevNumber)
                {
                    prevNumber = arr[i];
                }

                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("Max Number = " + maxNumber);
            SubOptions(_menuNumber);
        }
    }
}
