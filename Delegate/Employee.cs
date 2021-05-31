using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices.Delegate
{
    //delegate declare
    //delegate is a type save function pointer.
    public delegate string IsPromotable(Employee emp);

    public  class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public int Experince { get; set; }

        //IsPromotable delegate pointer function
        //Same return type like IsPromotable delegate
        public static string IsPromote(Employee emp)
        {
            if (emp.Experince > 5)
            {
                return "IsOk";
            }
            else
            {
                return "NotOk";
            }
        }
        public static void IsPromotedEmployee(List<Employee> empList, IsPromotable isEligibleForPromotion)
        {
            foreach (Employee employee in empList)
            {
                //IsPromotable delagate use
                if (isEligibleForPromotion(employee)== "IsOk")
                {
                    Console.WriteLine(employee.Name+" Promoted");
                }
                else
                {
                    Console.WriteLine(employee.Name + " Work hard for promotion");

                }
            }
        }
    }
}
