
using System;
using System.Linq;
using System.Collections.Generic;
using System.Reflection;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {

            //Type personInterface = typeof(Citizen).GetInterface("IPerson");
            //PropertyInfo[] properties = personInterface.GetProperties();
            //Console.WriteLine(properties.Length);
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //IPerson person = new Citizen(name, age);
            //Console.WriteLine(person.Name);
            //Console.WriteLine(person.Age);


            //Type identifiableInterface = typeof(Citizen).GetInterface("IIdentifiable");
            //Type birthableInterface = typeof(Citizen).GetInterface("IBirthable");
            //PropertyInfo[] properties = identifiableInterface.GetProperties();
            //Console.WriteLine(properties.Length);
            //Console.WriteLine(properties[0].PropertyType.Name);
            //properties = birthableInterface.GetProperties();
            //Console.WriteLine(properties.Length);
            //Console.WriteLine(properties[0].PropertyType.Name);
            //string name = Console.ReadLine();
            //int age = int.Parse(Console.ReadLine());
            //string id = Console.ReadLine();
            //string birthdate = Console.ReadLine();
            //IIdentifiable identifiable = new Citizen(name, age, id, birthdate);
            //IBirthable birthable = new Citizen(name, age, id, birthdate);


            //List<string> list = Console.ReadLine().Split().ToList();
            //string[] add = Console.ReadLine().Split().ToArray();
            //Phone phone = new Phone();
            //for(int i = 0; i < list.Count; i++)
            //{
            //    phone.Number = list[i];
            //    Console.WriteLine(phone.Calling());
            //}
            //for(int i = 0; i < add.Length; i++)
            //{
            //    phone.Addresse = add[i];
            //    Console.WriteLine(phone.Browsing());
            //}

        }
    }
}
