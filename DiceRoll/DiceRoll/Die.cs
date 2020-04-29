using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    class Die
    {
        private int numberOfSides;
        private RandomGenerator randomGen;
        private int rolledNumber;

        public Die(int numberOfSides, RandomGenerator randomGen)
        {
            this.numberOfSides = numberOfSides;
            this.randomGen = randomGen;
        }

        public int Roll()
        {
            this.rolledNumber = randomGen.NextInt(1, numberOfSides + 1);
            return this.rolledNumber;
        }
    }
}
