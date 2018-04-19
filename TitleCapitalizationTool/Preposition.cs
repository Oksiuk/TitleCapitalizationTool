namespace TitleCapitalizationTool
{
    internal class Preposition
    {
        private string[] prepositions;
        private int size = 9;

        public Preposition()
        {
            prepositions = new string[] { "at", "by", "in", "of", "on", "or", "out", "to", "up" };
        }

        public bool IsPreposition(string @string)
        {
            bool isPreposition = false;
            for (int i = 0; i < size; ++i)
            {
                if (prepositions[i] == @string)
                {
                    isPreposition = true;
                }
            }
            return isPreposition;
        }
    }
}