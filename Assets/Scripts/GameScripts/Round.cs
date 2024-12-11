using System;
using System.Collections.Generic;
using Players;

namespace GameScripts
{
    public class Round
    {
        public Player[] Players { get; set; }
        public int CurrentPlayerIndex { get; private set; }
        public Player CurrentPlayer => Players[CurrentPlayerIndex];
        
        private Dictionary<Guid, int> playerScores = new();
        
        public bool IsOver => CurrentPlayerIndex >= Players.Length;

        public Turn Turn { get; private set; }
        
        public Round()
        {
        }

        public Round(Player[] players)
        {
            Players = players;
        }

        public void NewTurn(Category category)
        {
            Turn = new Turn(CurrentPlayer, Questions.QuestionForCategory(category));
            CurrentPlayerIndex++;
        }

    }
}