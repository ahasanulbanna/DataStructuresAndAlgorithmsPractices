using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices.Abstraction
{
    public abstract class BaseEmployee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string GetFullName()
        {
            return this.FirstName + " " + LastName; 
        }
        public abstract int GetMonthlySalary();
    }
}
