using System.Collections.Generic;
using Players;

namespace GameScripts
{
    public class Turn
    {
        public Player Player { get; set; }
        public Question Question { get; set; }
        
        public Turn(Player player, Question question)
        {
            Player = player;
            Question = question;
        }
    }
}