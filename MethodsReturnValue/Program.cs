using System;

namespace MethodsReturnValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string friend1 = "Greg";
            string friend2 = "Slaw";
            string friend3 = "Ali";

            GreetFriend(friend1, friend2, friend3);
            Console.Read();

        }

        public static void GreetFriend(string friendName, string friendName2, string friendName3)
        {
            Console.WriteLine("Hi " + friendName + ", my friend!");
            Console.WriteLine("Hi " + friendName2 + ", my friend!");
            Console.WriteLine("Hi " + friendName3 + ", my friend!");
        }
    }
    
}
