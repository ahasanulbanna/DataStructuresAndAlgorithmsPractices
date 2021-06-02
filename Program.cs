using DataStructuresAndAlgorithmsPractices.Abstraction;
using DataStructuresAndAlgorithmsPractices.Delegate;
using DataStructuresAndAlgorithmsPractices.Dictionary;
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
            #region Abstraction
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
            #endregion

            #region LinkList
            NodeLink lnk = new NodeLink();
            lnk.AddFirst("First");
            lnk.AddLast("A");
            lnk.AddLast("B");
            lnk.AddLast("C");
            lnk.AddLast("Last");
            lnk.ReadAll();
            #endregion

            #region Delegate
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

            Func<Employee, string> selector = x => "Name=" + x.Name;
            IEnumerable<string> names = empList.Select(selector);
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Dictionary
            Customer customer1 = new Customer
            {
                CustomerId = 1,
                Name = "AAA"
            };
            Customer customer2 = new Customer
            {
                CustomerId = 2,
                Name = "BBB"
            };
            Customer customer3 = new Customer
            {
                CustomerId = 3,
                Name = "CCC"
            };
            //Key must be unique
            Dictionary<int, Customer> customerDic = new Dictionary<int, Customer>();
            customerDic.Add(1, customer1);
            customerDic.Add(2, customer2);
            customerDic.Add(3, customer3);
            foreach (KeyValuePair<int, Customer> item in customerDic)
            {
                Console.WriteLine("Id={0} Name={1}", item.Key, item.Value.Name);
            }
            #endregion



            Console.ReadKey();
            
        }
    }
}
