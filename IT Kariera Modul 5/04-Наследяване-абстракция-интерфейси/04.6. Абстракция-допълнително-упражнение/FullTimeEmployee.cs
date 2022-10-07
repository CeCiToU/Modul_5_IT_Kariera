using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Abstraction
{
    class FullTimeEmployee : BaseEmployee
    {
        string employeePosition;
        string employeeDepartment;
        public FullTimeEmployee(string id, string name, string address, string position, string department)
        : base(id, name, address)
        {
            employeePosition = position;
            employeeDepartment = department;
        }

        public string Show()
        {
            return $"{base.Shown()}\nPosition : {employeePosition}, Department: {employeeDepartment}.";
        }

        public override string CalculateSalary(int hours)
        {
            double salary = 250 + hours * 10.80;
            return $"Salary : {salary}";
        }

        public override string GetDepartmen()
        {
            return employeeDepartment;
        }
    }
}
