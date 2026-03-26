namespace CybersecurityChatbot
{
    internal class ResponseHandler
    {
        // Returns true if input is usable, false if it should be rejected
        public static bool IsValidInput(string? input)
        {
            return !string.IsNullOrWhiteSpace(input);
        }

        // Cleans up input — lowercase and trimmed — for consistent matching
        public static string Sanitise(string input)
        {
            return input.Trim().ToLower();
        }
    }
}
