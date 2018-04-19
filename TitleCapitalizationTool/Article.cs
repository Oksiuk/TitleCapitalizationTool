namespace TitleCapitalizationTool
{
    internal class Article
    {
        private string[] articles;
        private int size = 3;

        public Article()
        {
            articles = new string[size];
            articles[0] = "a";
            articles[1] = "an";
            articles[2] = "the";
        }

        public bool IsArticle(string @string)
        {
            bool isArticle = false;
            for (int i = 0; i < articles.Length; ++i)
            {
                if (articles[i] == @string)
                {
                    isArticle=true; 
                }
            }
            return isArticle; 
        }
    }
}