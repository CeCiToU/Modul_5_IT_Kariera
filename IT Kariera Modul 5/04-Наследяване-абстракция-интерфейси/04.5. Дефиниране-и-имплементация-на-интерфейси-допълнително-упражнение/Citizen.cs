using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Citizen : IPerson, IBirthable, IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        private string birthable;

        public Citizen(string name, int age)
        {
            this.age = age;
            this.name = name;
        }
        public Citizen(string name, int age, string id, string birthable)
        {
            this.age = age;
            this.name = name;
            this.birthable = birthable;
            this.id = id;
        }

        public int Age => this.age;


        public string Name => this.name;

        public string ID => this.id;

        public string Birthdate => this.birthable;
    }
}
