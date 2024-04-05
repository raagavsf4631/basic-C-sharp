using System;
using System.ComponentModel;

namespace program1;

class Program{

public static void Main(string[] args)
{
    
  
   
   string s="";
   do{
    Console.WriteLine("enter two number");
     int n = int.Parse(Console.ReadLine());
   int n1 = int.Parse(Console.ReadLine());
  
    Console.WriteLine("Enter the option:"+"\n"+"1.Addition"+"\n"+"2.subraction"+"\n"+"3.multiplication"+"\n"+"4.Division");
   int op = int.Parse(Console.ReadLine());
   switch(op){
    case 1:
     Console.WriteLine(Add(n,n1));
    break;
    case 2:
    Console.WriteLine(sub(n,n1));
    break;
    case 3:
    Console.WriteLine(mul(n,n1));
    break;
    case 4:
    Console.WriteLine(Div(n,n1));
    break;
    default:
    Console.WriteLine("Invalid");
    break;
   }
   Console.WriteLine("DO YOU WANT TO CONTINUE? TYPE-YES");
    s = Console.ReadLine().ToUpper();
   }while(s=="YES");

  char s ='k';
  
}

     static int Div(int n, int n1)
    {
       return n/n1;
    }

     static int mul(int n, int n1)
    {
        return n*n1;
    }

     static int sub(int n, int n1)
    {
       return n-n1;
    }

     static int Add(int n, int n1)
    {
        return n+n1;
    }
}