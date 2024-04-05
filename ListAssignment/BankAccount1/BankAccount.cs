using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace ListAssignment;

 public enum Gender{
        male,
        female
       }

    public class BankAccount
    {
        //field
        private static int _customerId=1000;

       //auto-property
       //static public int count=1;
       public string CustomerId {get;set;}
       public string CustomerName{get;set;}
       public double Balance{get;set;}
       
       
       public long Phone{get;set;}
       public string MailId{get;set;}
       public DateTime Dob{get;set;}

       Gender Gender;

        public BankAccount(string customerName,double balance,Gender gender, long phone,string mailId,DateTime dob)
       {
        
        CustomerName=customerName;
        Balance = balance;
        Gender =gender;
        Phone= phone;
        MailId=mailId;
        Dob =dob;
        CustomerId="HD"+_customerId++;
        
       }

       public void Deposit(double amt){
            Balance+=amt;
            Display();
       }

       public void Withdraw(double amt){
        Balance-=amt;
        Display();
       }

       public void Display(){
        Console.WriteLine("Your balance amount: "+Balance);
       }


    }

