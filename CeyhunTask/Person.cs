using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ceyhun
{
    internal class Person
    {
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        private string _fullName;
        public Person(string FullName,int Age,string PhoneNumber)
        {
            this.FullNamee = FullName;
            this.Age = Age;
            this.PhoneNumber = PhoneNumber;
        }

        public string FullNamee
        {
            get { return _fullName; }
            set 
            {
                if (IsFullName(value)) 
                {
                    _fullName = value;
                }
                else
                {
                    Console.WriteLine("Minimum 2 soz daxil edilmelidir ve boyuk herfle baslamalidir");
                }
            }
        }

        public bool IsFullName(string value) 
        {
            value = value.Trim();
            string[] parts = value.Split(' ');
            if(parts.Length < 2)
            {
                return false;
            }

            foreach (string item in parts)
            {
                if (!char.IsUpper(item[0]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
