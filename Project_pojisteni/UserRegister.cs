using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Project_pojisteni
{
    internal class UserRegister
    {  
        /// <summary>
        /// List that stores all users
        /// </summary>
        public List<User> usersList;
        public UserRegister()
        {
            usersList = new List<User>();
        }

        /// <summary>
        /// Adds a new user to the list of users
        /// </summary>
        /// <param name="name"> Name of the user</param>
        /// <param name="surname">Surname of the user</param>
        /// <param name="phoneNumber"></param>
        /// <param name="age"></param>
        public void AddNewUser(string name, string surname, int age, int phoneNumber)
        {
            usersList.Add(new User(name, surname, age, phoneNumber));
        }


        /// <summary>
        /// Returns all the users saved in the list
        /// </summary>
        public void ReturnUser()
        {
            foreach (User u in usersList)
                Console.WriteLine(u);
        }


        public void SearchUser(string name, string surname)
        {
            foreach (User u in usersList)
            {
                if (name.ToLower() == u.Name.ToLower() && surname.ToLower() == u.Surname.ToLower())
                {
                    Console.WriteLine("\nUsers found:\n");
                    Console.WriteLine(u);
                }

                else
                    Console.WriteLine("\nUser not found");

            }
        }
    }
}               


            


        





 