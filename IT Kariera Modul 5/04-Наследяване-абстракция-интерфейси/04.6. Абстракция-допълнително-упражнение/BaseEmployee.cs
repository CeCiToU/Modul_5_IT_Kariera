using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Abstraction
{
    abstract class BaseEmployee
    {
        string employeeID;
        string employeeName;
        string employeeAddress;
        public BaseEmployee(string id, string name, string address)
        {
            employeeAddress = address;
            employeeName = name;
            employeeID = id;
        }

        public abstract string CalculateSalary(int hours);
        public abstract string GetDepartmen();

        public string Shown()
        {
            return $"Name: {employeeName}, Address: {employeeAddress}, ID : {employeeID}.";
        }
    }
}
