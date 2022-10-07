using System;

namespace Exercise_Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = Console.ReadLine();
            string name = Console.ReadLine();
            string address = Console.ReadLine();
            string position = Console.ReadLine();
            string department = Console.ReadLine();

            FullTimeEmployee full = new FullTimeEmployee(id, name, address, position, department);

            Console.WriteLine(full.Show());
            Console.WriteLine(full.CalculateSalary(230));
            Console.WriteLine(full.GetDepartmen());

            string id1 = Console.ReadLine();
            string name1 = Console.ReadLine();
            string address1 = Console.ReadLine();
            string task = Console.ReadLine();
            string department1 = Console.ReadLine();

            ContractEmployee cont = new ContractEmployee(id1,name1,address1, task, department1);

            Console.WriteLine(cont.Show());
            Console.WriteLine(cont.CalculateSalary(230));
            Console.WriteLine(cont.GetDepartmen());
        }
    }
}
