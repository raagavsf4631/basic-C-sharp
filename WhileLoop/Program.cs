// See https://aka.ms/new-console-template for more information\


using System;
namespace IfCondition;
class Program{
    public static void Main(string[] args)
    {
        int i=1;
        while(i<25){
            if(i%2==0){
                Console.WriteLine(i);
            }
            i++;
        }
        // 2.
         bool n =false;
         while(n==false){
        int num ;
        Console.WriteLine("enter the number");
         n = int.TryParse(Console.ReadLine(),out num);
         if(n==true){
            break;
         }else{
            Console.WriteLine("Number is invalid. Enter the valid number");
         }
        }

    
    }
    }