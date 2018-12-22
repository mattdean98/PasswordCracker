using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordCracker
{
    class Program
    {
        static void Main(string[] args)
        {
            var entry = "";
            Console.WriteLine("Welcome to Password Cracker, made by Matt Dean as a side project for educational purposes only.");
            do {
                Console.Write("Do you want to generate 100 passwords? (Y/N): ");
                entry = Console.ReadLine();
                if (entry.ToUpper() == "Y")
                {
                    GeneratePasswords();
                }
                else if (entry.ToUpper() == "N")
                {
                    //get user to input a password
                }
            }
            while (entry.ToUpper() != "Y" && entry.ToUpper() != "N");
            Console.Write("Enter the format of the password you want to crack (\"l\" for letter and \"n\" for number, example \"llllnn\"): ");
            CrackPassword(Console.ReadLine());
        }
        static void GeneratePasswords()
        {

        }
        static void CrackPassword(string format)
        {

        }
    }
}
