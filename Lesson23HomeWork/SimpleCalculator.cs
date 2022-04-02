using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson23HomeWork
{
    internal class SimpleCalculator
    {
        public int NumberGetter()
        {
            int x;
            Console.WriteLine("Please enter a positive number");
              x = int.Parse(Console.ReadLine());
            while (x < 0)
            {
                Console.WriteLine("Your number is negative please enter a positive number");
                x = int.Parse(Console.ReadLine());

            }
            return x;
        }
        public void PrintMenu()
        {
            Console.WriteLine("The options are: 1 for + \n 2 for *\n 3 for -\n 4 for /");
        }
        public int GetUserChoice()
        {
            int x;
            Console.WriteLine("Please enter number between 1 to 4");
            x = int.Parse(Console.ReadLine());
            while (x>4 && x<1)
            {
                Console.WriteLine("Again,please enter number between 1 to 4");
                x = int.Parse(Console.ReadLine());

            }
            return x;
        }
        public int Calculate(int num1,int num2, int operation)
        {
            int result=1;
            switch(operation)
            {
                case 1: result= num1 + num2;
                    break;
                case 2: result = num1 * num2;
                    break;
                case 3: result = num1 - num2;
                    break;
                case 4: result = num1 / num2;
                    break;
            }
            return result;
        }
        public void PrintResultNicely(double num)
        {
          
            Console.WriteLine("***"+num+"***");
            
        }
    }
}
