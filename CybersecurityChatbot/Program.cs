using System;
using System.Media;
using System.Threading;

class CyberSecurityChatbot
{
    static void Main()
    {
        Console.Title = "Cybersecurity Awareness Chatbot";

        // Step 1: Play the Greeting Sound
        PlayGreeting();

        // Step 2: Display ASCII Art
        DisplayASCIIArt();

        // Step 3: Welcome Message
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\nWelcome to the Cybersecurity Awareness Chatbot!");
        Console.ResetColor();

        // Step 4: Ask for User Name
        string userName = GetValidInput("\nEnter your name: ");
        Console.WriteLine($"\nHello, {userName}! How can I assist you with cybersecurity today?\n");

        // Step 5: Start Chat Loop
        while (true)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\nAsk a cybersecurity-related question (or type 'exit' to quit): ");
            Console.ResetColor();

            string question = Console.ReadLine()?.Trim().ToLower();

            if (question == "exit")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nThank you for using the Cybersecurity Awareness Chatbot. Stay safe online! 🔒");
                Console.ResetColor();
                break;
            }

            RespondToUser(question);
        }
    }

    // Function to play voice greeting
    static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("Assets/greeting.wav");
            player.PlaySync(); // Play audio synchronously
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("⚠️ Warning: Could not play greeting sound.");
            Console.ResetColor();
        }
    }

    // Function to display ASCII Art
    static void DisplayASCIIArt()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(@"
 ██████╗ ██╗   ██╗██████╗ ███████╗██████╗ ██╗   ██╗
██╔═══██╗██║   ██║██╔══██╗██╔════╝██╔══██╗██║   ██║
██║   ██║██║   ██║██████╔╝█████╗  ██████╔╝██║   ██║
██║▄▄ ██║██║   ██║██╔═══╝ ██╔══╝  ██╔═══╝ ██║   ██║
╚██████╔╝╚██████╔╝██║     ███████╗██║     ╚██████╔╝
 ╚══▀▀═╝  ╚═════╝ ╚═╝     ╚══════╝╚═╝      ╚═════╝ 
");
        Console.ResetColor();
    }

    // Function to validate user input (not empty)
    static string GetValidInput(string prompt)
    {
        string input;
        do
        {
            Console.Write(prompt);
            input = Console.ReadLine()?.Trim();
        } while (string.IsNullOrEmpty(input));

        return input;
    }

    // Function to respond to user questions
    static void RespondToUser(string question)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        switch (question)
        {
            case "how are you?":
                Console.WriteLine("I'm just a bot, but I'm here to help with cybersecurity! 😊");
                break;
            case "password safety":
                Console.WriteLine("Use strong passwords with at least 12 characters, including letters, numbers, and symbols.");
                break;
            case "phishing":
                Console.WriteLine("Avoid clicking on suspicious emails or links that ask for personal details.");
                break;
            case "two-factor authentication":
                Console.WriteLine("Enable 2FA on all important accounts to add an extra layer of security.");
                break;
            case "malware":
                Console.WriteLine("Always install reputable antivirus software and avoid downloading files from untrusted sources.");
                break;
            default:
                Console.WriteLine("I'm not sure about that. Try asking about 'password safety' or 'phishing'.");
                break;
        }
        Console.ResetColor();
    }
}
