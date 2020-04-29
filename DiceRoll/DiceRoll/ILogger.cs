using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoll
{
    interface ILogger
    {
        void Log(ILogable data);
    }
}
