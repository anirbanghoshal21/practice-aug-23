using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, r;
            Console.Write("Enter any two numbers: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            r = a + b;
            Console.Write("Sum of Two Numbers: " + r);

            Console.ReadLine();
        }
        }
    }

