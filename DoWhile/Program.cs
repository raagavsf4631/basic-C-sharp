using System;
namespace IfCondition;
class Program{
    public static void Main(string[] args)
    {
        String s ="" ;
        do{
             Console.WriteLine("enter the number");
             int num = int.Parse(Console.ReadLine());
            if(num%2==0){
                 Console.WriteLine("Numbwer is even");
            }else{
                 Console.WriteLine("Number is odd");
            }

             Console.WriteLine("Do you want repeat? Type yes/no");
              s = Console.ReadLine();
              

              if(!s.Equals("no") && !s.Equals("yes")){
                do{
                Console.WriteLine("invalid input enter valid input: ");
                s = Console.ReadLine();
              }while(!s.Equals("no") && !s.Equals("yes"));
              }
              
              if(s=="no"){
                break;
               }
              
        }while(s=="yes");
    }
    }
