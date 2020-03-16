using System;
using System.Collections.Generic;
using System.Text;

namespace NumberGame
{
    class RandomNumGen
    {

        Random random = new Random();
        public int RandomNumber(int min, int max)
        {
            return random.Next(min, max);
        }

    }
}
