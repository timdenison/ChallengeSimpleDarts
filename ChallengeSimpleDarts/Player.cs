using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDarts
{
    public class Player
    {
        public string Name;
        public int Score;

       
        public Player (string playerName)
        {
            this.Name = playerName;
            this.Score = 0;

        }
    }
}