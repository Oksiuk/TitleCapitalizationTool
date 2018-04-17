﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            for (int i = 0; i < articles.Length; ++i)
            {
                if (articles[i] == @string)
                {
                    return true;
                }
            }
            return false; ;
        }
    }
}