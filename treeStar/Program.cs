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
            string userInput = "1";
            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("How Tall do you want your tree?", Console.ForegroundColor);
                Console.Write(">", Console.ForegroundColor);
                userInput = Console.ReadLine();
                int height = 0;

                if (IsInteger(userInput))
                {
                    height = Convert.ToInt32(userInput);
                    if (height < 2 || height > 100 )
                    { 
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Lets keep it between 2 and 100", Console.ForegroundColor);
                    }
                    else
                    {
                        // spaces and stars to start
                        int spaces = height;
                        int stars = 1;
                        for (int i = 0; i < height; i++)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (i == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                            }
                            StringBuilder line = new StringBuilder();
                            line.Append(' ', spaces).Append('*', stars);
                            Console.WriteLine(line.ToString(), Console.ForegroundColor);
                            spaces--;
                            stars += 2;
                        }
                    }
                }   
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Entered an invalid integer\n", Console.ForegroundColor);
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
