using System;
using System.Collections.Generic;
using System.Linq;
using Players;
using Unity.VisualScripting;

namespace GameScripts
{
    public class Round
    {
        public List<Player> Players { get; set; }
        public int CurrentPlayerIndex { get; private set; }
        public Player CurrentPlayer => Players[CurrentPlayerIndex];
        public bool IsOver => CurrentPlayerIndex >= Players.Count;
        public Turn Turn { get; private set; }
        public int RoundNumber { get; set; }
        
        public Round()
        {
        }

        public Round(IEnumerable<Player> players)
        {
            Players = players.ToList();
        }

        public void NewTurn(Category category)
        {
            Turn = new Turn(CurrentPlayer, Questions.QuestionForCategory(category));
            CurrentPlayerIndex = Math.Min(CurrentPlayerIndex + 1, Players.Count);
        }
        
        
        public Round NewRound()
        {
            return new Round(Players)
            {
                RoundNumber = RoundNumber + 1
            };
        }
    }
}