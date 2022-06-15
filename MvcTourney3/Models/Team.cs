﻿namespace MvcTourney3.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Game
        {
            get; set;
        }
        public string School { get; set; }

        public List<Player> Players { get; set; } = new List<Player>();
    }
}
