using core;
using System.Reflection.Metadata;
using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp23
{
    public class Program
    {
        public static List<User> users = new List<User>();
        static void Main(string[] Args)
        {
            Console.WriteLine("adi daxil edin:");
            string name= Console.ReadLine();
            Console.WriteLine("soyadi daxil edin:");
            string surname= Console.ReadLine();
            Console.WriteLine("istifadeci adini daxil edin:");
            string username = Console.ReadLine();
            Console.WriteLine("sifreni daxil edin");
            string password = Console.ReadLine();
            Autherization.Register = (name, password, username, surname);

        }
    }
}