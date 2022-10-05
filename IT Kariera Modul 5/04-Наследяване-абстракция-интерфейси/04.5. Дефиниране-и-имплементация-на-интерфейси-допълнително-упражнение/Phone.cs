using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Phone : IPhone
    {
        string number;
        string addresse;

        public string Number { get => number; set => number = value; }
        public string Addresse
        {
            get { return addresse; }
            set
            {
                for(int i = 0; i < 10; i++)
                {
                    if (value.Contains($"{i}"))
                    {
                        addresse = "Invalid URL!";
                        break;
                    }
                    else
                    {
                        addresse = value;
                    }
                }
            }
        }

        public Phone()
        {

        }

        public string Calling()
        {
            return $"Calling... {Number}";
        }

        public string Browsing()
        {
            return $"Browsing: {Addresse}";
        }
    }
}
