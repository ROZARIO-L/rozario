using System.IO;
using System;

class Program
{
    static void Main()
    {
        int age;
        Console.Write("Enter an age: "); 
        age=Convert.ToInt32(Console.ReadLine());
        
        if(age<18)
        {
          Console.Write("voter is not eligible ");   
        }
        else if(age>=60)
        {
         Console.Write("voter is a senior citizen ");      
        }
        else
        {
         Console.Write("voter is  eligible ");      
        }
        
    }
}