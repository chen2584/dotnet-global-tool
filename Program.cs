using System;

namespace dotnetcore
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("--- Welcome to ChenToolszz! ---");
            if (args.Length == 0)
            {
                System.Console.WriteLine("Please enter a options.");
                System.Console.WriteLine("Usage: chen-tool install <os>");
                return;
            }

            if (args[0].Equals("install"))
            {
                if (args.Length >= 2)
                {
                    System.Console.WriteLine();
                    switch (args[1].ToLower())
                    {
                        case "windows":
                            Console.WriteLine("Installed on Windows!");
                            break;
                        case "mac":
                            Console.WriteLine("Installed on Mac!");
                            break;
                        case "linux":
                            Console.WriteLine("Installed on Linux!");
                            break;
                        default:
                            Console.WriteLine("Usage: chen-tool install <os> (os is windows, mac, and linux only)");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Please specific OS for install");
                    Console.WriteLine("Usage: chen-tool install <os> (os is windows, mac, and linux only)");
                }
            }



            return;
        }
    }
}
