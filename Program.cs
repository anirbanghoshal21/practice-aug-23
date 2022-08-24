using System;
using System.Xml.Linq;


struct employee
{
    public int empno;
    public string ename;
    public double sal;
    public int deptno;
};

public class Structure
{

    public static void Main(string[] args)
    {
        employee employees1;

        employees1.empno = 1;
        employees1.ename = "Ashok Gupta";
        employees1.sal = 4322;
        employees1.deptno = 64;


        Console.WriteLine("employees 1 empno : {0}", employees1.empno);
        Console.WriteLine("employees 1 ename : {0}", employees1.ename);
        Console.WriteLine("employees 1 sal : {0}", employees1.sal);
        Console.WriteLine("employees 1 deptno :{0}", employees1.deptno); 
    }

        public int empno
    {
        get
        {
            return empno;
        }
        set
        {
            empno = value;
        }
    }

    public string ename
    {
        get
        {
            return ename;
        }
        set
        {
            ename = value;
        }
    }

    public double sal
    {
        get
        {
            return sal;
        }
        set
        {
            sal = value;
        }
    }

    public int deptno
    {
        get
        {
            return deptno;
        }
        set
        {
            deptno = value;
        }
    }

    public override string ToString()
    {
        return "empno = " + empno + ", ename = " + ename + ", sal = " + sal; 
    }

}
class ExampleDemo
{
    public static void Main()
    {
        employee e = new employee();

        e.deptno = 1;
        e.ename = "Ashok Gupta";
        e.sal = 4322;
        e.deptno = 64;
        Console.WriteLine("Employee Info: {0}", e);


        Console.ReadKey();
    }
}
