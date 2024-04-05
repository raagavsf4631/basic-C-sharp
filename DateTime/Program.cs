using System;
using System.Linq.Expressions;
using System.Net.Mail;
namespace StringManipulation;
class Program
{
    public static void Main(string[] args)
    {
        DateTime dob =new DateTime(2021,8,10,10,40,32);
        Console.WriteLine(dob.ToString("yyyy/MM/dd h:m:s tt"));
       
        String[] s = dob.ToString("yyyy/MM/dd h:m:s tt").Split('/',':',' ');
        for (int i =s.Length-1; i >=0 ; i--)
        {
            Console.Write(s[i]+" ");
        }
        Console.WriteLine();
        DateTime d = DateTime.ParseExact(Console.ReadLine(),"yyyy/MM/dd h:m:s tt",null);
        Console.WriteLine(d.Year.ToString()+" "+d.Month+" "+ d.Day);
        dob.Da
        math
        
    }
}