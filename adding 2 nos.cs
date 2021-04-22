using System.IO;
using System;

class Program
{
    static void Main()
    {
        int firstno , secondno, result;
        Console.Write("Enter first number: "); 
        firstno=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        Console.Write("Enter second number: ");
        secondno=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();
        result = firstno+secondno;
        Console.WriteLine("sum of two numbers is :{0}",result);
       
    }
}