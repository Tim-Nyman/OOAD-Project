using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Alley.src
{
    public class PlayerFactory
    {
        public Player CreatePlayer(string username)
        {
            return new Player(username);
        }
    }
}