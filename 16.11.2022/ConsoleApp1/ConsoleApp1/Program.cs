using System;

namespace ConsoleApp1
{
    internal class Program
    {
        private static object testc;

        public static string number { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter your favourite football player t-shirt number!");
            string  number = Console.ReadLine();
            int numberParsed = Int16.Parse(number);

            //teen siia if ja else loogikaga vastused

           if (numberParsed <7)
            {
                Console.WriteLine("kaka");
            }
           else if (numberParsed > 7 && numberParsed <50)
            {
                Console.WriteLine("kaka2");
            }
           else if (numberParsed > 51 && numberParsed < 100 )
            {
                Console.WriteLine("kaka3");
            }







        }
    }
}
