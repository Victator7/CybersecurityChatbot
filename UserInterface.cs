namespace CybersecurityChatbot
{
    internal class UserInterface
    {

        //C olour Pallet to be used
        // Names are self-explanatory.
        private const ConsoleColor AsciiColour = ConsoleColor.Green;// ASCII Art
        private const ConsoleColor BotColour = ConsoleColor.Yellow;// Bot dialogue

        private const ConsoleColor UserColour = ConsoleColor.Cyan;// User dialogue
        private const ConsoleColor DividerColour = ConsoleColor.DarkGray;//For dividers and such
        private const ConsoleColor ErrorColour = ConsoleColor.Magenta;
        private const ConsoleColor InfoColour = ConsoleColor.White;


        // UserInterface Methods are '''static''' to make them easier to call in ChatBot.cs
        // This method displays the ASCII art (half of which was sourced from patorjk.com)
        public static void DisplayArt()
        {
            Console.ForegroundColor = AsciiColour;
            Console.WriteLine(@"
        .----.
       / .--. \
      | |    | |
      | |    | |
       \ '--' /
    .============.
    |  SECURED   |
    |   > _ <    |
    |            |
    '============'

  ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
 ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
 ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝ - security bot
 ╚██████╗  ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
  ╚═════╝   ██║   ██████╔╝███████╗██║  ██║
            ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝
            ");
            Console.ResetColor();
        }

        //This method prints a 'lil divider to make things appear neater than they are.
        public static void PrintDivider()
        {
            Console.ForegroundColor = DividerColour;
            Console.WriteLine(new string('─', 60));
            Console.ResetColor();
        }

        //Prints another divider...but bigger
        public static void PrintDoubleDivider()
        {
            Console.ForegroundColor = DividerColour;
            Console.WriteLine(new string('═', 60));
            Console.ResetColor();
        }

        //Prints text centred inside a bordered box
        public static void PrintBoxedTitle(string title)
        {
            int width = 58;
            int padding = (width - title.Length) / 2;
            string centred = new string(' ', padding) + title;

            Console.ForegroundColor = AsciiColour;
            Console.WriteLine("┌" + new string('─', width) + "┐");
            Console.WriteLine("│" + centred.PadRight(width) + "│");
            Console.WriteLine("└" + new string('─', width) + "┘");
            Console.ResetColor();
        }


        // Gives that "typing" effect.
        public static void TypeWrite(string message, int delayMs = 50)
        {
            Console.ForegroundColor = InfoColour;
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(delayMs);
            }
            Console.ResetColor();
            Console.WriteLine();
            Thread.Sleep(delayMs * 20);
        }

        // Prints the Bot's dialogue
        public static void PrintBotMessage(string message)
        {
            Console.ForegroundColor = BotColour;
            Console.Write("\n [BOT] ");
            Console.ResetColor();

            TypeWrite(message);
        }

        // *** For when Bot encounters an error (testing - will remove later)
        public static void PrintBotError(string message)
        {
            Console.ForegroundColor = ErrorColour;
            Console.Write("\n [BOT] ");
            Console.ResetColor();
            TypeWrite(message);
        }

        // A regular message, but in colour.
        public static void PrintColoured(string message, ConsoleColor colour)
        {
            Console.ForegroundColor = colour;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        // Displays the user's name during dialogue
        public static void PrintUserPrompt(string userName)
        {
            Console.WriteLine();
            Console.ForegroundColor = UserColour;
            Console.Write($" [{userName}] > ");
            Console.ResetColor();
        }

        // For printing headers.
        public static void PrintSectionHeader(string title)
        {
            Console.WriteLine();
            PrintDivider();
            Console.ForegroundColor = AsciiColour;
            Console.WriteLine($"  {title.ToUpper()}");
            Console.ResetColor();
            PrintDivider();
        }
    }
}
