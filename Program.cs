using System;
using System.Collections.Generic;

namespace login_MC
{
    class Program
    {
        static Dictionary<string, string> users = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("This will be the login screen. Please login below:");
            Console.WriteLine("Please provide a Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Please provide a password:");
            string userPass = Console.ReadLine();
            users.Add($"{userName}", $"{userPass}");
            Console.WriteLine($@"Thank you for logging in:
Your User Name: {users.Keys}");
        }
    }
}
