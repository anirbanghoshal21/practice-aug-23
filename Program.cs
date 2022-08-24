using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int result = 15 / int.Parse("0");
                Console.WriteLine(result);
            }
            catch (DivideByZeroException e)
            {
                Console.Write(e.Message);
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
