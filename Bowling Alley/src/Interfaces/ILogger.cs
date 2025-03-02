using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace Bowling_Alley.src
{
    public interface ILogger
    {
        void Log(string message);
    }
}