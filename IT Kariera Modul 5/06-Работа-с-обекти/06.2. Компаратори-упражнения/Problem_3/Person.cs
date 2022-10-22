using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparer_Exercises
{
    class Person : IComparable<Person>
    {
        private string name;
        private int age;
        private string cityName;

        public Person(string name, int age, string cityName)
        {
            this.Name = name;
            this.Age = age;
            this.CityName = cityName;
        }

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public string CityName { get => cityName; set => cityName = value; }

        public int CompareTo(Person other)
        {
            int res = this.Name.CompareTo(other.Name);
            if(res == 0)
            {
                res = this.Age.CompareTo(other.Age);
            }
            if(res == 0)
            {
                res = this.CityName.CompareTo(other.CityName);
            }
            return res;
        }
    }
}
