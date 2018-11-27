using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreaterCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first Number: ");
            int numb1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second Number: ");
            int numb2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your third Number: ");
            int numb3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetMax(numb1, numb2, numb3));

            Console.ReadLine();
        }

        static int GetMax(int num1, int num2, int num3)
        {
            int result;

            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;
            }

            return result;
        }
    }
}

// Author Joshua Pryor, Twitter @Felty_OW, email feltdev@gmail.com
