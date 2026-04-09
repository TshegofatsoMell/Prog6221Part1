using System;
using System.Threading;

namespace CyberSecurityChatBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enhanced Console UI with Visual Elements
            Console.Title = "Cyber Security Awareness Bot";
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=========================================");
            Console.WriteLine("|   Cyber " +
                "/nSecurity" +
                " Awareness Bot   |");
            Console.WriteLine("=========================================");
            Console.ResetColor();

            // Display ASCII image
            Console.ForegroundColor = ConsoleColor.Magenta; // Changed to purple (Magenta is closest to purple in console colors)
            Console.WriteLine(@"
            ___
          /       \
         /         \
        |   BOT    |
         \         /
          \___/
            ");
            Console.ResetColor();

            // Typing effect
            TypeMessage("Hello! I'm your Cyber Security Awareness Assistant.\n");
            TypeMessage("What's your name? ");

            // Get user name
            string name = Console.ReadLine();

            // Handle empty input
            if (string.IsNullOrWhiteSpace(name))
            {
                name = "User";
            }

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("=========================================");
            Console.WriteLine($"|   Welcome, {name}!   |");
            Console.WriteLine("=========================================");
            Console.ResetColor();

            while (true)
            {
                TypeMessage("\nHow can I help you? (Type 'help' for options, 'exit' to quit): ");
                string input = Console.ReadLine().ToLower();

                // Handle invalid inputs
                if (string.IsNullOrWhiteSpace(input))
                {
                    TypeMessage("I didn't quite understand that. Could you rephrase?");
                    continue;
                }

                // Basic Response System
                switch (input)
                {
                    case "help":
                        DisplayHelp();
                        break;
                    case "password tips":
                        DisplayPasswordTips();
                        break;
                    case "phishing awareness":
                        DisplayPhishingAwareness();
                        break;
                    case "network security":
                        DisplayNetworkSecurity();
                        break;
                    case "exit":
                        TypeMessage("Goodbye!");
                        return;
                    default:
                        TypeMessage("I didn't quite understand that. Could you rephrase?");
                        break;
                }
            }
        }

        static void TypeMessage(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(50); // Adjust speed as needed
            }
        }

        static void DisplayHelp()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nAvailable options:");
            Console.WriteLine("- Password tips");
            Console.WriteLine("- Phishing awareness");
            Console.WriteLine("- Network security");
            Console.WriteLine("- Exit");
            Console.ResetColor();
        }

        static void DisplayPasswordTips()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Password Tips:");
            Console.ResetColor();
            Console.WriteLine("- Use at least 12 characters");
            Console.WriteLine("- Mix uppercase, lowercase, numbers, and symbols");
            Console.WriteLine("- Avoid common words or phrases");
            Console.WriteLine("- Use a password manager");
        }

        static void DisplayPhishingAwareness()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Phishing Awareness:");
            Console.ResetColor();
            Console.WriteLine("- Be cautious of unsolicited emails or messages");
            Console.WriteLine("- Avoid suspicious links or attachments");
            Console.WriteLine("- Never provide sensitive information");
            Console.WriteLine("- Verify sender information");
        }

        static void DisplayNetworkSecurity()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Network Security:");
            Console.ResetColor();
            Console.WriteLine("- Use a VPN when on public Wi-Fi");
            Console.WriteLine("- Keep software up-to-date");
            Console.WriteLine("- Use strong passwords and 2FA");
            Console.WriteLine("- Monitor accounts and reports");
        }
    }
}