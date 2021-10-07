using System;

namespace Password_maker
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Random rnd = new Random();
                string password = "1234567890qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM";
                Console.WriteLine("How many characters in password?");
                try
                {
                    int times = Convert.ToInt32(Console.ReadLine());
                    for(int i = 0; i < times; i++)
                    {
                        Console.Write(password[rnd.Next(password.Length)]);
                    }
                    Console.WriteLine();
                }
                catch
                {
                    Console.WriteLine("Try again");
                    continue;
                }
            }
        }
    }
}
