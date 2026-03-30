namespace CybersecurityChatbot
{

    //This class handles all user inputs, bot responses, and related methods
    internal class ResponseHandler
    {
        // An array for storing chatbot responses (and the keywords for summoning them) 
        private readonly Dictionary<string, List<string>> responses;
        private readonly Random random = new Random();
        private string userName;
        public string UserName => userName;

        // This method populates the array 
        public ResponseHandler(string userName)
        {
            this.userName = userName;

            responses = new Dictionary<string, List<string>>
{
    {
        "password",
        new List<string>
        {
            "Great question, {name}! Alsways use strong, unique passwords for every account.\n " +
            "That means at least 12 characters, including letters, numbers and symbols.\n " +
            "A password manager helps keep them at hand.",

            "Passwords are your first line of defence, {name}! So avoid using personal\n " +
            "details (like birthdays or pet names). Instead, try a passphrase,\n " +
            "since a random string of words is easier to remember.",

            "Here's a 'lil tip, {name}: never reuse passwords across different accounts.\n " +
            "If one site is breached, attackers will try the same password everywhere.\n " +
            "A password manager makes this easy to manage."
        }
    },
    {
        "phishing",
        new List<string>
        {
            "Watch out for phishing, {name}! These emails impersonate trusted organisations\n " +
            "to steal your details. Never click suspicious links or share personal info via email.",

            "Phishermen are getting smarter, {name}. Always check the sender's ACTUAL\n " +
            "email address and NOT just the display name. Legitimate companies will never ask\n " +
            "you for your password or personal info via email.",

            "A good rule of thumb, {name}: if an email creates a sense of urgency\n " +
            "('Your account will be closed!'), that is usually a red flag. Scammers\n " +
            "use panic to make you act without thinking. Navigating to the site\n " +
            "directly rather than clicking on the links also helps a bunch."
        }
    },
    {
        "browsing",
        new List<string>
        {
            "Safe browsing is essential, {name}. Always check for HTTPS (as opposed to HTTP)\n " +
            "in the address bar before entering any personal information.",

            "When browsing, {name}, be cautious about the sites you visit (you know what I mean)\n " +
            "Avoid downloading software from unofficial sources, and consider using a reputable\n " +
            "ad blocker to reduce exposure to malicious ads.",

            "Public Wi-Fi is always a risk, {name}! Avoid accessing sensitive accounts like\n " +
            "banking on public networks. If you must, use a VPN to encrypt your connection."
        }
    },
    {
        "privacy",
        new List<string>
        {
            "Privacy matters, {name}! Review the permissions you grant to apps.\n " +
            "Does a flashlight app really need access to your contacts? Probably not... ",

            "A good privacy habit to remember, my dear {name}, is to regularly check\n " +
            "which apps have access to your location, microphone and camera. Revoke\n " +
            "anything that seems unnecessary.",

            "Think before you share, {name}. Personal details posted publicly on social media\n " +
            "can be used by attackers to answer your security questions or craft targeted scams."
        }
    },
    {
        "two-factor",
        new List<string>
        {
            "Two-factor authentication (2FA) is one of the best things you can enable.\n " +
            "Even if someone steals your password, they still can't get in without the second factor.\n ",

            "Not all 2FA's are created equal, {name}. Authenticator apps like Google\n " +
            "or Microsoft Authenticator are more secure than SMS codes, which can\n " +
            "be intercepted via SIM-swapping attacks.",
        }
    },
    {
        "malware",
        new List<string>
        {
            "Malware is malicious software designed to damage or gain access to your system, {name}.\n " +
            "Keep your operating system and antivirus software up to date to stay protected.\n " +
            "And don't click sketchy links!",

            "Watch out for unexpected downloads, {name}. Malware often disguises itself as a\n " +
            "legitimate file or software update. Only download from trusted, official sources."
        }
    },
    {
        "purpose",
        new List<string>
        {
            "I'm your Cybersecurity Awareness Bot, {name}! My purpose is to help you understand\n " +
            "and avoid cyber threats like phishing, weak passwords, and unsafe browsing.",

            "Great question, {name}! I'm here to explain a few cybersecurity topics to you!\n " +
            "Ask me about any online safety topic and I'll do my best to help."
        }
    },
    {
        "how are you",
        new List<string>
        {
            "So far so good, {name}\n " +
            "How can I help you stay safe today?",

            "Ready to help you navigate the world of cybersecurity!",
        }
    },
    {
        "help",
        new List<string>
        {
            "Of course, {name}! You can ask me about passwords, phishing scams,\n " +
            "safe browsing, privacy, malware, or two-factor authentication.\n " +
            "Type 'exit' whenever you're done.",

            "Here to help, {name}. Try asking about a specific topic like phishing or\n " +
            "password safety, or just tell me what you're worried about online\n " +
            "and I'll do my best to help."
        }
    },
    {
        "what can",
        new List<string>
        {
            "You can ask me about quite a few things, {name}! Try: passwords, phishing,\n " +
            "safe browsing, privacy, malware, or two-factor authentication.",
        }
    }
};
        }
        //Actually returns the chatbot'd responses
        public string GetResponse(string input)
        {
            foreach (var entry in responses)
            {
                if (input.Contains(entry.Key))
                {
                    string response = entry.Value[random.Next(entry.Value.Count)];
                    return response.Replace("{name}", userName);
                }
            }

            return $"I didn't quite understand that, {userName}. " +
                   "Could you try rephrasing? You can ask me about\n " +
                   "passwords, phishing, safe browsing, or type 'help' for a full list.";
        }

        public static bool IsValidInput(string? input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        // Changes the imput to lowercase and trimmed for consistent matching.
        public static string TrimToLower(string input)
        {
            return input.Trim().ToLower();
        }

        //changes "friend" to the user's name if needed (in the dictionary)
        public void SetUserName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                return;

            if (name.Length == 1)
                userName = name.ToUpper();
            else
                userName = char.ToUpper(name[0]) + name.Substring(1);
        }
    }
}