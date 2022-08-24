using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            int c = 0;

            try
            {
                c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                Console.ReadLine();   
            }
            finally
            {
                Console.Write("Re-try with a different number.");
            }
        }
    }
}
