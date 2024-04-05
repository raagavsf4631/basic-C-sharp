using  System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace CollageApplication;
class Program{
    public static void Main(string[] args)
    {
        List<Student> studentlist = new List<Student>();
         string Option="";

        do{

                Student student1 =new Student();
                studentlist.Add(student1);
                // Console.WriteLine("Enter the name: ");
               // student1.studentname = Console.ReadLine();
               Console.WriteLine("Enter the Father name: ");
                student1.fathername = Console.ReadLine();
                Console.WriteLine("Enter the Date birth ");
                student1.dob = DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                


            Console.WriteLine("Do you want to continue");
             Option = Console.ReadLine();

        }while(Option=="yes");
        
        foreach (Student item in studentlist){
            Console.WriteLine("student name "+item.studentname);
            Console.WriteLine("Father name:"+item.fathername);
            Console.WriteLine("date of birth "+item.dob);
           
        }
       


    }
}
