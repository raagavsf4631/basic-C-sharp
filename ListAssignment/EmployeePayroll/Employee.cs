using System;

namespace EmployeePayroll
{
    enum Gender{
        male,
        female
    }
    public class Employee
    {
        private static int _employeeId=1000;
        public string EmployeeId{set;get;}


          string Employeename{set;get;}
          string Role{set;get;}
          string Teamname{set;get;}
          string DOJ{set;get;}
          string Workingdays{set;get;}
          string Leavetaken{set;get;}

          public Employee(string employeeName,string role,string teamname, string Doj,string workingdays,string leavetaken){
            Employeename = employeeName;
            Role = role;
            Teamname = teamname;
            DOJ = Doj;
            Workingdays = workingdays;
            Leavetaken = leavetaken; 
          }

          void display(){
            Console.WriteLine(Employeename);
            Console.WriteLine(EmployeeId);
            Console.WriteLine(Role);
            Console.WriteLine(Teamname);
            Console.WriteLine(DOJ);
            
          }

        
    }
}
