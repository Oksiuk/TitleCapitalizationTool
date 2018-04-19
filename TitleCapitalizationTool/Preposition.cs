namespace TitleCapitalizationTool
{
    internal class Preposition
    {
        private string[] prepositions;
        private int size = 9;

        public Preposition()
        {
            prepositions = new string[size];
            prepositions[0] = "at";
            prepositions[1] = "by";
            prepositions[2] = "in";
            prepositions[3] = "of";
            prepositions[4] = "on";
            prepositions[5] = "or";
            prepositions[6] = "out";
            prepositions[7] = "to";
            prepositions[8] = "up";
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