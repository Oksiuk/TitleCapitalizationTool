using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleCapitalizationTool
{
    class Punctuation
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
            for (int i = 0; i < size; ++i)
            {
                if (punctuations[i] == @string)
                {
                    return true;
                }
            }
            return false;
        }
        public bool IsSpace(string @string)
        {
            if (@string == punctuations[6])
            {
                return true;
            }
            return false;
        }
    }
}
