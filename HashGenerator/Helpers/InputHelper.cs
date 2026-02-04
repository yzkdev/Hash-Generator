using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashGenerator.Helpers
{
    public class InputHelper
    {
        public static string ReadStringInput()
        {
            string input = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.Write("Error! Try again: ");
                return ReadStringInput();
            }
            else
            {
                return input;
            }
        }

        public static int ReadIntInput()
        {
            while(true)
            {
                string input = Console.ReadLine();
                
                if(int.TryParse(input, out int number))
                {
                    return number;
                }
                else
                {
                    Console.Write("Error! Try again: ");
                }
            }
        }
    }
}