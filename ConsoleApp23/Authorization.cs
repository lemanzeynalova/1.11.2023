using ConsoleApp23;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    static class Authorization
    {
        public static User LoggedIn;
        public static void Register(string name, string password, string Surname, string Username)
        {
            if(Username.Length>4 && password.Length > 6)
            {
                User user = new User();
                user.Password = password;
                user.Name = name;
                user.Username = Username;
                Program.users.Add(user);
            }
        }


        public static void Login(string name, string password)
        {

        }
        public static void Info()
        {

            for (int i = 0; i < Program.users.Count; i++)
            {
                Console.WriteLine("istifadeci adini daxil edin:");

            }

        }
        public static void Logout()
        {

        }
        public static void LogIn()
        {
            for(int i = 0;i < Program.users.Count;i++) 
            {
                Console.WriteLine();
            }
        }

    }
    
  

}    


