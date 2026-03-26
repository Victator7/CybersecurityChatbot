namespace CybersecurityChatbot
{
    internal class UserInterface
    {
        // Collection of '''static''' UI methods (easier to call)
        // This one prints a message in a chosen colour, then resets the colour
        public static void PrintColoured(string message, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // This one simulates a "typing" by printing one character at a time (very noice)
        public static void TypeWrite(string message, int delayMs = 18)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.ResetColor();
            Console.WriteLine();
        }

        // Prints a lil' line for a clean structure
        public static void PrintDivider()
        {
            PrintColoured(new string('─', 60), ConsoleColor.DarkGray);
        }

        // Displays the ASCII art header (sourced from patorjk.com)
        public static void DisplayAsciiArt()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@"
 ██████╗██╗   ██╗██████╗ ███████╗██████╗ ███████╗███████╗ ██████╗██╗   ██╗██████╗ ██╗████████╗██╗   ██╗   
██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔════╝██╔════╝██╔════╝██║   ██║██╔══██╗██║╚══██╔══╝╚██╗ ██╔╝   
██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝███████╗█████╗  ██║     ██║   ██║██████╔╝██║   ██║    ╚████╔╝    
██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗╚════██║██╔══╝  ██║     ██║   ██║██╔══██╗██║   ██║     ╚██╔╝     
╚██████╗   ██║   ██████╔╝███████╗██║  ██║███████║███████╗╚██████╗╚██████╔╝██║  ██║██║   ██║      ██║      
 ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝  ╚═╝╚═╝   ╚═╝      ╚═╝      
                                                                                                          
 █████╗ ██╗    ██╗ █████╗ ██████╗ ███████╗███╗   ██╗███████╗███████╗███████╗    ██████╗  ██████╗ ████████╗
██╔══██╗██║    ██║██╔══██╗██╔══██╗██╔════╝████╗  ██║██╔════╝██╔════╝██╔════╝    ██╔══██╗██╔═══██╗╚══██╔══╝
███████║██║ █╗ ██║███████║██████╔╝█████╗  ██╔██╗ ██║█████╗  ███████╗███████╗    ██████╔╝██║   ██║   ██║   
██╔══██║██║███╗██║██╔══██║██╔══██╗██╔══╝  ██║╚██╗██║██╔══╝  ╚════██║╚════██║    ██╔══██╗██║   ██║   ██║   
██║  ██║╚███╔███╔╝██║  ██║██║  ██║███████╗██║ ╚████║███████╗███████║███████║    ██████╔╝╚██████╔╝   ██║   
╚═╝  ╚═╝ ╚══╝╚══╝ ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═══╝╚══════╝╚══════╝╚══════╝    ╚═════╝  ╚═════╝    ╚═╝   
                                                                                                                                                                                     
                                                                                                       
        Cybersecurity Awareness Bot
            ");
            Console.ResetColor();
        }

        // Displays the bot's responses.
        public static void PrintBotMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("[BOT] ");
            Console.ResetColor();
            TypeWrite(message);
        }

        // Displays the user's responses.
        public static void PrintUserPrompt(string userName)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write($"[{userName}] ");
            Console.ResetColor();
        }
    }
}
