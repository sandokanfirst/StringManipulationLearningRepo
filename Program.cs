//demo from https://wellsb.com/csharp/
using System;

namespace StringManipulation
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Reverse String");
            Console.WriteLine("2) Remove Whitespace");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ReverseStringUI();
                    return true;
                case "2":
                    RemoveWhitespaceUI();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

        private static void ReverseStringUI()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");
            DisplayResult(StringManipulator.ReverseString(CaptureInput()));
        }

        private static void RemoveWhitespaceUI()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");
            DisplayResult(StringManipulator.RemoveWhitespace(CaptureInput()));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }
    }

    class StringManipulator
    {
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return String.Concat(charArray);
        }

        public static string RemoveWhitespace(string s)
        {
            return s.Replace(" ", "");
        }

    }
}
