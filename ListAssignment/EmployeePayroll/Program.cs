using System;
using System.Collections.Generic;
namespace EmployeePayroll;
//using System.Runtime.InteropServices;

class Program
{
  public static void Main(string[] args)
  {

    List<Employee> CustomerList = new List<Employee>();
    string Option = "yes";
    do
    {
      Console.WriteLine("Enter the option 1.Registration 2.Login 3.Exit ");
      int op = int.Parse(Console.ReadLine());
      switch (op)
      {
        case 1:
          
          Console.WriteLine("Enter your name: ");
          string Employeename = Console.ReadLine();
          Console.WriteLine("Enter your role: ");
          string role = Console.ReadLine();
          Console.WriteLine("Enter your Teamname: ");
          string Teamname = Console.ReadLine();
          Console.WriteLine("Enter your DOJ: ");
          string DOJ = Console.ReadLine();
          Console.WriteLine("Enter your No of workingdays: ");
          string workingdays = Console.ReadLine();
          Console.WriteLine("Enter No of Leave taken: ");
          string leavetaken = Console.ReadLine();

          break;

          case 2:

          Console.WriteLine("Enter your EmployeeID: ");
          string Employeeid = Console.ReadLine();
          bool user = false;
          Employee userid = null;
          foreach (Employee item in CustomerList)
          {
            if (Employeeid == item.EmployeeId)
            {
              user = true;
              userid = item;
            }
          }

          if (user)
          {

            string ch = "yes";
            do
            {
              Console.WriteLine("Enter the option 1.calculate salary 2.display details  4.Exit ");
              int p = int.Parse(Console.ReadLine());
              switch (p)
              {
                case 1:
                  Console.WriteLine("Enter your deposit money: ");
                  double deposit = double.Parse(Console.ReadLine());
                
                  break;
                case 2:
                  userid.display();
                  break;
                case 3:
                  Option = "yes";
                  ch = "no";
                  break;
                default:
                  Console.WriteLine("Invalid input");
                  break;
              }
            } while (ch == "yes");

          }
          else
          {
            Console.WriteLine("Invalid user ID");
          }

          break;
          
          

      }
    }while(Option=="yes");
  }
}
