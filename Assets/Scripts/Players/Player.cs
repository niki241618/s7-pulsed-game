using System;

namespace Players
{
    public class Player
    {
        public string Name { get; set; }
        public int Score { get; set; }
        public Guid Id { get; set; }

        public Player(string name)
        {
            Name = name;
            Score = 0;
            Id = Guid.NewGuid();
        }
    }
}
