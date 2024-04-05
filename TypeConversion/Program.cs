using System;
namespace TypeConversion;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        String name = Console.ReadLine();
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("enter the mark of subject1:");
        double mark1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the mark of subject2:");
        double mark2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the mark of subject3:");
        double mark3 = double.Parse(Console.ReadLine());
        Console.Write("enter the grade: ");
        char grade = char.Parse(Console.ReadLine());
        Console.Write("enterthe mobile number:");
        long mobile = long.Parse(Console.ReadLine());
        Console.Write("Enter thw mail Id:");
        String mail = Console.ReadLine();
        double total = mark1+mark2+mark3;
        double avg = total/3;
        Console.WriteLine("\nTrainee Details Are:\n"+"Name: "+name+"\nAge: "+age+"\nmobile: "+mobile+"\nMark1: "+mark1+"\nMark2: "+mark2+"\nMark3: "+mark3+"\ntotal: "+total+"\navg: "+avg+"\ngrade: "+grade+"\nMail: "+mail);
    }
}