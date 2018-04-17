using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleCapitalizationTool
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a name of smth:");
            string inputString = Console.ReadLine();
            inputString = inputString.Trim();

            Article articles = new Article();
            Conjuction conjuctions = new Conjuction();
            Preposition prepositions = new Preposition();
            Punctuation punctuations = new Punctuation();

            string[] words = inputString.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder resultBuilder = new StringBuilder();
            StringBuilder wordBuilder = new StringBuilder();

            for (int i = 0; i < words.Length; ++i)
            {
                if (articles.IsArticle(words[i]) == false && conjuctions.IsConjuction(words[i]) == false
                    && prepositions.IsPreposition(words[i]) == false && punctuations.IsPunctuation(words[i]) == false)
                {
                    wordBuilder.Clear();
                    char[] symbol = words[i].ToCharArray();

                    for (int j = 0; j < symbol.Length; ++j)
                    {
                        if (j == 0)
                        {
                            symbol[j] = char.ToUpper(symbol[j]);
                        }
                        else
                        {
                            symbol[j] = char.ToLower(symbol[j]);
                        }
                        wordBuilder.Append(symbol[j]);
                    }
                    resultBuilder.Append(wordBuilder);
                }
                else if (articles.IsArticle(words[i]) == true || conjuctions.IsConjuction(words[i]) == true || prepositions.IsPreposition(words[i]) == true)
                {
                    wordBuilder.Clear();
                    char[] symbol = words[i].ToCharArray();

                    for (int j = 0; j < symbol.Length; ++j)
                    {
                        if (i == 0 && j == 0)
                        {
                            symbol[j] = char.ToUpper(symbol[j]);
                        }
                        else
                        {
                            symbol[j] = char.ToLower(symbol[j]);
                        }
                        wordBuilder.Append(symbol[j]);
                    }
                    resultBuilder.Append(wordBuilder);
                }
                else if (punctuations.IsPunctuation(words[i]) == true)
                {
                    if (punctuations.IsSpace(words[i]) == true)
                    {
                        resultBuilder.Append(" ");
                    }
                    resultBuilder.Append(words[i]);
                }
                if (i != words.Length - 1 && punctuations.IsPunctuation(words[i + 1]) == false)
                {
                    resultBuilder.Append(" ");
                }
            }
            Console.WriteLine(resultBuilder);
        }
    }
}
    

