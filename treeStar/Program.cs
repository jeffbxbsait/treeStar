using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeStar
{
    class Program
    {
        static void Main(string[] args)
        {
            string star = *;
            string userInput = "";
            do
            {
                Console.WriteLine("How Tall do you want your tree?\n:>");
                userInput = Console.ReadLine();
                int height = 0;

                if (IsInteger(userInput))
                {
                    Console.WriteLine("Entered valid integer\n");

                }   
                else
                {
                    Console.WriteLine("Entered an invalid integer\n");
                }

            } while (userInput != "");
        }

        // Yolands validation example
        public static bool IsInteger(string input)
        {
            int myNum;
            if (Int32.TryParse(input, out myNum))
            {
                return true;
            } 
            else
            {
                return false;
            }
        }
    }
}
