using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.login
{
    class User
    {
        string username;
        string password;

        public string UserName {
            get
            {
                return username;

            }
            set
            {
                this.username = value;
                if (value.Length<5)
                {
                    throw new Exception("Minimum 5 simvoldan ibaret olmalidir!");
                    
                }

            }
        }
        public string Password
        {
            get
            {
                return password;
            }
            set
            {
               this.password = value;
                if (value.Length<8)
                {
                    throw new Exception("Minimum 8 Simvoldan ibaret olmalidir!");
                }
            }

        }


        public bool Login()
        {
            if (username=="Alizadehh" && password=="987654321")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        
        

        

        public User()
        {
            Console.WriteLine("Sisteme Xosh gelmishsiniz!");
        }
    }
}
