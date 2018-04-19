namespace TitleCapitalizationTool
{
    internal class Punctuation
    {
        private string[] punctuations;
        private int size = 7;

        public Punctuation()
        {
            punctuations = new string[size];
            punctuations[0] = ",";
            punctuations[1] = ";";
            punctuations[2] = ":";
            punctuations[3] = ".";
            punctuations[4] = "!";
            punctuations[5] = "?";
            punctuations[6] = "-";
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