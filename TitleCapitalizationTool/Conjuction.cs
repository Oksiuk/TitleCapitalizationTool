﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TitleCapitalizationTool
{
    internal class Conjuction
    {
        private string[] conjuctions;
        private int size = 6;
        public Conjuction()
        {
            conjuctions = new string[size];
            conjuctions[0] = "and";
            conjuctions[1] = "but";
            conjuctions[2] = "for";
            conjuctions[3] = "nor";
            conjuctions[4] = "so";
            conjuctions[5] = "yet";
        }
        public bool IsConjuction(string @string)
        {
            for (int i = 0; i < size; ++i)
            {
                if (conjuctions[i] == @string)
                {
                    return true;
                }
            }
            return false;
        }
    }
}