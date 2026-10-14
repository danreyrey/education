using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2025_12_09_OOP
{
    public class Regular : BusinessAccount
    {
        private int EmployeeCount { get; set; }

        public Regular(string customerNumber, string accountNumber, string bankCode, int employeeCount) : base(customerNumber, accountNumber, bankCode)
        {
            EmployeeCount = employeeCount;
        }

        //public int GetEmployeeCount() => this.EmployeeCount;

        //public void SetEmployeeCount(int newEmployeeCount) => this.EmployeeCount = newEmployeeCount;
    }
}
