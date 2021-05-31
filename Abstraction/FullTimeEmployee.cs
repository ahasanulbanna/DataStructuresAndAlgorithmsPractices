using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices.Abstraction
{
    public class FullTimeEmployee: BaseEmployee
    {
        public int AnualSalary { get; set; }
        public override int GetMonthlySalary()
        {
            return this.AnualSalary / 12;
        }
    }
}
