using System;
namespace IfCondition;
class Program{
    public static void Main(string[] args)
    {
        Console.Write("Enter input1: ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter input2: ");
        int num2 = int.Parse(Console.ReadLine());
        Console.Write("Enter operator: ");
        char op = char.Parse(Console.ReadLine());
        switch(op){
            case '+':{
                 Console.Write(num1+num2);
                break;
            }
            case '-':{
                Console.Write(num1+num2);
                break;
            }
            case '*':{
                Console.Write(num1*num2);
                break;
            }
            case '/':{
                Console.Write(num1/num2);
                break;
            }
            case '%':{
                Console.Write(num1%num2);
                break;
            }
            default:
                Console.Write("Invalid ");
                break;
            
            
        }
    }
}