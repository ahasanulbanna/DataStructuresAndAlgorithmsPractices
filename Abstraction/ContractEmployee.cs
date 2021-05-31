using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithmsPractices.Abstraction
{
    public class ContractEmployee: BaseEmployee
    {
        public int HourlyPay { get; set; }
        public int TotalHours { get; set; }
        public override int GetMonthlySalary()
        {
            return HourlyPay* TotalHours;
        }
    }
}
