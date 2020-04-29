using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    class ConsoleLogger : ILogable
    {
        public void Log(ILogable data)
        {
            Console.WriteLine(data);
        }
    }
}
