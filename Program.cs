namespace CybersecurityChatbot
{
    //This class contains the main method, and call the chatbot class to launch the actual program.
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creates a little instance of Chatbot and launches it (please work)
            ChatBot bot = new ChatBot();
            bot.Start();
        }
    }
}