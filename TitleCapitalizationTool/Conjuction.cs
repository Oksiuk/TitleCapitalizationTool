namespace TitleCapitalizationTool
{
    internal class Conjuction
    {
        private string[] conjuctions;
        private int size = 6;

        public Conjuction()
        {
            conjuctions = new string[] { "and", "but", "for", "nor", "so", "yet" };
        }

        public bool IsConjuction(string @string)
        {
            bool isConjuction = false;
            for (int i = 0; i < size; ++i)
            {
                if (conjuctions[i] == @string)
                {
                    isConjuction = true;
                }
            }
            return isConjuction;
        }
    }
}