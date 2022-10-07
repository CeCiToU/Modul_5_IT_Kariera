using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Abstraction
{
    class ContractEmployee : BaseEmployee
    {
        string employeeTask;
        string employeeDepartment;
        public ContractEmployee(string id, string name, string address, string task, string department) : base(id, name, address)
        {
            employeeTask = task;
            employeeDepartment = department;
        }

        public string Show()
        {
            return $"{base.Shown()}\nTask: {employeeTask}.";
        }

        public override string CalculateSalary(int hours)
        {
            double salary = 250 + hours * 20;
            return $"Salary : {salary}";
        }

        public override string GetDepartmen()
        {
            return employeeDepartment;
        }
    }
}
