using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bowling_Alley.src
{
    public class AddPlayerToDb
    {
        public void Add(List<Player> players)
        {
            var dbConn = DataContext.Instance;
            dbConn.AddPlayers(players);
        }
    }
}