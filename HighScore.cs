﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGame
{
    class HighScore
    {
        string name;

        int score;
        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public HighScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }
    }
}
