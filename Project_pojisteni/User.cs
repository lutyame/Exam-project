using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_pojisteni
{
    internal class User
    {
        public string Name {get; set;}
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
         


        public User (string name, string surname, int age, int phoneNumber)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PhoneNumber = phoneNumber;
           
        }

        public override string ToString()
        {
            return Name + "\t" + Surname + "\t" + Age + "\t" + PhoneNumber + "\n" ;
        }
    }

}
