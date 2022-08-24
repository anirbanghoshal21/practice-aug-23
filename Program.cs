using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            employee[] employees = new employee[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Enter empno");
                int empno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter ename");
                string ename = Console.ReadLine();
                Console.WriteLine("Enter salary");
                double sal = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter deptno");
                int deptno = Convert.ToInt32(Console.ReadLine());
                employees[i].AcceptData(empno, ename, sal, deptno);
            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine = (employees[i].Display());
            }
            Console.Read();
        }
    }
    struct employee
    {
        int _empno;
        string _ename;
        double _sal;
        int _deptno;

        public void AcceptData(int empno, string ename, double sal, int deptno);
        {
        this._empno = empno;
        this._ename = ename;
        this._sal = sal;
        this._deptno = deptno;
       }
    public void Display();
    {
    Console.WriteLine(_empno);
            
        }
    }
}
