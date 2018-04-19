namespace TitleCapitalizationTool
{
    internal class Punctuation
    {
        private string[] punctuations;
        private int size = 7;

        public Punctuation()
        {
            punctuations = new string[] { ",", ";", ":", ".", "!", "?", "-" };
        }

        public bool IsPunctuation(string @string)
        {
            bool isPunctuation = false;
            for (int i = 0; i < size; ++i)
            {
                if (punctuations[i] == @string)
                {
                    isPunctuation = true;
                }
            }
            return isPunctuation;
        }

        public bool IsSpace(string @string)
        {
            bool isSpace = false;
            if (@string == punctuations[6])
            {
                isSpace = true;
            }
            return isSpace;
        }
    }
}