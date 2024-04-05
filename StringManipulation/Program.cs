using System;
using System.Linq.Expressions;
namespace StringManipulation;
class Program
{
    public static void Main(string[] args){
        Console.WriteLine("Enter main input");
        String maininput = Console.ReadLine();
        Console.WriteLine("Enter short input");
        String shortinput = Console.ReadLine();

        String[] s =maininput.Split(shortinput);
        Console.WriteLine(s.Length-1);
        // foreach(String i in s){
        //     Console.WriteLine(i);
        // }
    }
}