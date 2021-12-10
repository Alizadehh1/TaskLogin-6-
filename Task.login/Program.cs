using System;

namespace Task.login
{
    class Program
    {
        static void Main(string[] args)
        {
            User u = new User();

            Console.Write("User Name: ");
            u.UserName = Console.ReadLine();

            Console.Write("Password: ");
            u.Password = Console.ReadLine();

            bool IsLoggedOn = u.Login();

            if (IsLoggedOn)
            {
                Console.WriteLine($"Xosh gelmisiz @{u.UserName}");
            }
            else
            {
                Console.WriteLine("Sansinizi  bir daha sinayin!");
            }
            Console.ReadKey();


            
        }
    }
}
