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
            string star = "*";
            string userInput = "";
            do
            {
                Console.WriteLine("How Tall do you want your tree?\n:>");
                userInput = Console.ReadLine();
                int height = 0;

                if (IsInteger(userInput))
                {
                    Console.WriteLine("Entered valid integer\n");
                    height = Convert.ToInt32(userInput);
                    if (height < 2 || height > 100 )
                    {
                        Console.WriteLine("Lets keep it between 2 and 100");
                    }
                    else
                    {
                        // spaces and stars to start
                        int spaces = height / 2;
                        int stars = 1;
                        for (int i = 1; i < height; i++)
                        {
                            Console.WriteLine(spaces + star);
                            // updated stars and spaces
                            if (spaces.Length > 1)
                        }
                    }
                }   
                else
                {
                    Console.WriteLine("Entered an invalid integer\n");
                }

            } while (userInput != "");

 }
        // print a bunch of the same char
        public static string ManyCharsToString(int num, char c)
        {
            string returnString = "";
            for (int i, )
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
