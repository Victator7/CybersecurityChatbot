namespace CybersecurityChatbot
{

    // The class that contains the main program loop.
    internal class ChatBot
    {
        private readonly ResponseHandler responseHandler;
        private string userName = "Friend"; // default if user decides to skip the name entry thing I worked so hard on...

        public ChatBot()
        {
            responseHandler = new ResponseHandler("friend");
        }


        //This is the magic method that pulls everything together (hopefully)
        public void Start()
        {
            // Set the window title bar
            Console.Title = "Cybersecurity Awareness Bot";
            Console.Clear();

            //Play the recording to greet the user
            //AudioPlayer.PlayGreeting(); (still working on it.)

            //Display the Art and the title with a brief pause for dramatic effect
            UserInterface.DisplayArt();
            Thread.Sleep(400);
            UserInterface.PrintDoubleDivider();
            Thread.Sleep(400);
            UserInterface.PrintBoxedTitle("Cybersecurity Awareness Bot v1.0");
            Thread.Sleep(400);
            UserInterface.PrintDoubleDivider();
            Thread.Sleep(400);

            UserInterface.PrintBotMessage(
                "Welcome! I'm your Cybersecurity Awareness Assistant.");
            UserInterface.PrintBotMessage(
                "I'm here to help you stay safe online.");

            UserInterface.PrintDivider();

            GreetUser();
            RunLoop();
        }

        //This method greets the user and asks for a name
        private void GreetUser()
        {

            UserInterface.PrintBotMessage("Before we begin, what's your name?");
            UserInterface.PrintUserPrompt("You");

            string? input = Console.ReadLine();

            responseHandler.SetUserName(input!);
            this.userName = responseHandler.UserName;

            UserInterface.PrintDivider();

            // Displays a personalised welcome
            UserInterface.PrintBotMessage(
                $"Great to meet you, {userName}!");
            UserInterface.PrintBotMessage(
                "Here's what you can ask me about:");

            // Displays a list of topics for users to choose from
            UserInterface.TypeWrite(
                "• Password safety", 45, ConsoleColor.Green, 200);
            UserInterface.TypeWrite(
                "• Phishing scams", 45, ConsoleColor.Green, 200);
            UserInterface.TypeWrite(
                "• Safe browsing habits", 45, ConsoleColor.Green, 200);
            UserInterface.TypeWrite(
                "• Malware", 45, ConsoleColor.Green, 200);
            UserInterface.TypeWrite(
                "• Two-factor verification", 45, ConsoleColor.Green, 200);
            UserInterface.TypeWrite(
                "• Privacy tips", 45, ConsoleColor.Green, 200);

            UserInterface.PrintBotMessage(
                $"What would you like to know, {userName}?");
            UserInterface.PrintDivider();
        }

        // This is the main conversation loop that loops until the user "quits"
        // or closes the program
        private void RunLoop()
        {
            while (true)
            {



                UserInterface.PrintUserPrompt(userName);
                string? input = Console.ReadLine();

                // For if the user input is incoherent
                if (!ResponseHandler.IsValidInput(input))
                {
                    UserInterface.PrintBotError(
                        "It looks like you didn't really type anything. " +
                        $"What would you like to know, {userName}?");
                    continue;
                }

                string trimmed = ResponseHandler.TrimToLower(input!);

                // For if the user exits 
                if (IsExitCommand(trimmed))
                {
                    UserInterface.PrintBotMessage(
                        $"It was great chatting with you, {userName}! " +
                        "Stay safe and vigilant out there. Goodbye! ");
                    break;
                }

                // Get and display the response
                string response = responseHandler.GetResponse(trimmed);
                UserInterface.PrintBotMessage(response);
                UserInterface.PrintDivider();

                UserInterface.PrintBotMessage(
                $"What else can I help you with, {userName}?");
                UserInterface.PrintDivider();
            }
        }

        // Checks if the user response was an exit prompt
        private static bool IsExitCommand(string input)
        {
            return input is "exit" or "quit" or "bye"
                or "goodbye" or "close" or "stop";// More options pending
        }
    }
}
