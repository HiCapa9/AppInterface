using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppInterface
{
    class PasswordManager: IDisplayable, IResetable
    {
        private string Password
        { get; set; }

        public bool Hidden
        { get; private set; }

        public string HeaderSymbol { get; }

        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
            this.HeaderSymbol = "-------";
        }

        public PasswordManager(string password, bool hidden, string headerSymbol)
        {
            Password = password;
            Hidden = hidden;
            this.HeaderSymbol = headerSymbol;
        }

        public void Display() {

            Console.WriteLine("The Password \n" + HeaderSymbol);

            if (Hidden == false)
                Console.WriteLine($"The password is: {Password}");
            else
                Console.WriteLine(String.Concat(Enumerable.Repeat("*", Password.Length)));
            Console.WriteLine();
        }

        public void Reset() {
            Password = "";
            Hidden = false;
        
        }
    }
}
