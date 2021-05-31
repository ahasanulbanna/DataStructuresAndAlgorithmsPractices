using DataStructuresAndAlgorithmsPractices.Abstraction;
using DataStructuresAndAlgorithmsPractices.Delegate;
using DataStructuresAndAlgorithmsPractices.LinkList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------FullTimeEmployee-----------------");
            FullTimeEmployee fe = new FullTimeEmployee
            {
                FirstName = "Ahasanul",
                LastName = "Banna",
                AnualSalary = 300000
            };
            Console.WriteLine(fe.GetFullName());
            Console.WriteLine(fe.GetMonthlySalary());
            Console.WriteLine("--------------ContractEmployee-----------------");
            ContractEmployee ce = new ContractEmployee
            {
                FirstName = "XXXX",
                LastName = "YYYY",
                HourlyPay = 100,
                TotalHours = 8
            };
            Console.WriteLine(ce.GetFullName());
            Console.WriteLine(ce.GetMonthlySalary());



            NodeLink lnk = new NodeLink();
            lnk.AddFirst("First");
            lnk.AddLast("A");
            lnk.AddLast("B");
            lnk.AddLast("C");
            lnk.AddLast("Last");
            lnk.ReadAll();


            List<Employee> empList = new List<Employee>();
            empList.Add(new Employee { EmployeeId = 1, Name = "AAA", Experince = 3, Salary = 40000 });
            empList.Add(new Employee { EmployeeId = 2, Name = "BBB", Experince = 6, Salary = 100000 });
            empList.Add(new Employee { EmployeeId = 3, Name = "CCC", Experince = 3, Salary = 40000 });
            empList.Add(new Employee { EmployeeId = 4, Name = "DDD", Experince = 7, Salary = 100000 });
            empList.Add(new Employee { EmployeeId = 5, Name = "EEE", Experince = 3, Salary = 40000 });
            empList.Add(new Employee { EmployeeId = 6, Name = "FFF", Experince = 8, Salary = 100000 });
            empList.Add(new Employee { EmployeeId = 7, Name = "GGG", Experince = 3, Salary = 40000 });
            //function call use delegate
            Employee.IsPromotedEmployee(empList, Employee.IsPromote);

            Console.ReadKey();
            
        }
    }
}
