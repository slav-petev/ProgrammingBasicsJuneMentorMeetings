using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessThePassword
{
    class GuessThePasswordExcercise
    {
        static void Main(string[] args)
        {
            const string secretPassword = "s3cr3t!P@ssw0rd";

            var userPassword = Console.ReadLine();

            if (userPassword == secretPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
