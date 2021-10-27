using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeworkModule5
{
    class Program
    {
        static void Main(string[] args)
        {
            //PhoneNumberTask1();
            //CapitalLetterTask2();
            #region Task1

            static void PhoneNumberTask1()
            {
                Console.WriteLine("Phone number pattern: +XX YYY-YYY-YYY");
                Console.WriteLine("Input a phone number: ");

                var phoneNumber = Console.ReadLine();

                string pattern = "\\+\\d{2}\\s\\d{3}-\\d{3}-\\d{3}";

                var rgx = new Regex(pattern);              

                if (rgx.IsMatch(phoneNumber))
                {
                    Console.WriteLine($"Phone number {phoneNumber} has correct format");
                }
                else
                {
                    Console.WriteLine($"Phone number {phoneNumber} has wrong format");
                }
                
                Console.ReadLine();         
            }

            #endregion

            #region Task2

            static void CapitalLetterTask2()
            {
                Console.WriteLine("Please input a string to check if every word begins with capital letter: ");
                string stringInput = Console.ReadLine();

                string pattern1 = "^[A-Z][a-zA-Z]+";
                string pattern2 = " ";
                var rgx = new Regex(pattern1);

                bool TrueOrFalse = true;

                string[] words = Regex.Split(stringInput, pattern2);

                foreach (string everyWord in words)
                {
                    if (!rgx.IsMatch(everyWord))
                    {
                        TrueOrFalse = false;
                        break;
                    }
                }

                if (TrueOrFalse == true)
                {
                    Console.WriteLine($"{stringInput}: every word in the string STARTS with capital letter");
                }

                if (TrueOrFalse == false)
                {
                    Console.WriteLine($"{stringInput}: at least one word DOESNT start with capital letter");
                }

                Console.ReadLine();
            }

            #endregion
        }
    }
}
