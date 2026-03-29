namespace CybersecurityChatbot
{
    internal class ChatBot
    {
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
            UserInterface.PrintDoubleDivider();
            UserInterface.PrintBoxedTitle("Cybersecurity Awareness Bot v1.0");
            UserInterface.PrintDoubleDivider();
            Thread.Sleep(400);

            UserInterface.PrintBotMessage(
                "Welcome! I'm your Cybersecurity Awareness Assistant.");
            UserInterface.PrintBotMessage(
                "I'm here to help you stay safe online.");

            UserInterface.PrintDivider();

            //GreetUser();
            //RunLoop();
        }
    }
}
