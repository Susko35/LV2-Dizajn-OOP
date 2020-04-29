using System;

namespace DiceRoll
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dice rolling program");

            RandomGenerator randomGen = new RandomGenerator();
            DiceRoller roller = new DiceRoller();

            for(int i=0;i<20;i++)
            {
                roller.InsertDie(new Die(6, randomGen));
            }
        }
    }
}
