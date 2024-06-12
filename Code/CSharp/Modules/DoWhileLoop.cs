using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code.CSharp.Modules
{
    public class DoWhileLoop
    {
        public static void Login(string username,
                                 string password)
        {
            bool a = false;
            Console.WriteLine("Enter your username");
            string username2 = Console.ReadLine();
            Console.WriteLine("Enter your password");
            string password2 = Console.ReadLine();
            do
            {

                if (username2 != username)
                {

                    Console.WriteLine("Username is not correct, enter again.");
                    username2 = Console.ReadLine();

                }
                else if (password2 != password)
                {

                    Console.WriteLine("Password is not correct, enter again.");
                    password2 = Console.ReadLine();
                    continue;
                }
                else
                {
                    a = true;
                    Console.WriteLine("Login successful");
                }
            } while (a is false);
        }
    }
}
