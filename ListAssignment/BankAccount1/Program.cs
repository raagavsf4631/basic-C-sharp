using System;
using System.Collections.Generic;
//using System.Runtime.InteropServices;
namespace ListAssignment;
class Program
{
  public static void Main(string[] args)
  {

    List<BankAccount> CustomerList = new List<BankAccount>();
    string Option = "yes";
    do
    {
      Console.WriteLine("Enter the option 1.Registration 2.Login 3.Exit ");
      int op = int.Parse(Console.ReadLine());
      switch (op)
      {
        case 1:
          
          Console.WriteLine("Enter your name: ");
          string customername = Console.ReadLine();
          Console.WriteLine("Enter your deposit money: ");
          double balance = double.Parse(Console.ReadLine());
          Console.WriteLine("Enter your Gender");

          Gender Gender = Enum.Parse<Gender>(Console.ReadLine(),true);
          Console.WriteLine("Enter your phone: ");
          long phoneno = long.Parse(Console.ReadLine());
          Console.WriteLine("Enter your MailId: ");
          string mailId = Console.ReadLine();
          Console.WriteLine("Enter your Dateofbirth: ");
          DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

          /// create method and call it

          BankAccount customer1 = new BankAccount( customername, balance, Gender, phoneno, mailId, dob);

          CustomerList.Add(customer1);
          Console.WriteLine("User Account is created. User details: ");
            Console.WriteLine("CustomerID: "+customer1.CustomerId);
           Console.WriteLine("name:"+customername);
           Console.WriteLine("Balance: "+balance);
           Console.WriteLine("Gender: "+Gender);
           Console.WriteLine("Phoneno: "+phoneno);
           Console.WriteLine("MailId: "+mailId);
           Console.WriteLine("DateofBirth: "+dob);
          break;
        case 2:
          Console.WriteLine("Enter your CustomerID: ");
          string customerid = Console.ReadLine();
          bool user = false;
          BankAccount userid = null;
          foreach (BankAccount item in CustomerList)
          {
            if (customerid == item.CustomerId)
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
              Console.WriteLine("Enter the option 1.Deposit 2.Withdraw 3.balance check 4.Exit ");
              int p = int.Parse(Console.ReadLine());
              switch (p)
              {
                case 1:
                  Console.WriteLine("Enter your deposit money: ");
                  double deposit = double.Parse(Console.ReadLine());
                  userid.Deposit(deposit);
                  break;
                case 2:
                  Console.WriteLine("Enter your Withdraw money: ");
                  double withdraw = double.Parse(Console.ReadLine());
                  userid.Withdraw(withdraw);
                  break;
                case 3:
                  userid.Display();
                  break;
                case 4:
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
        case 3:
          Option = "no";

          break;
        default:
          Console.WriteLine("Invalid input");
          break;

      }

    } while (Option == "yes");


  }

}

// private static bool VerifyCustomer(string customerid,List<BankAccount> CustomerList)
// {
//     foreach (BankAccount item in CustomerList)
//     {
//         if(customerid==item.CustomerId){
//             return true;
//         }
//     }
//     return false;
// }
