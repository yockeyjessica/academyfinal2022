namespace MvcTourney3.Models
{
    public class Tournament
    {
        public Team Team
        {
            get; set;
        }

        public int TeamId
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }
        public string? Season
        {
            get; set;
        }
        public int? GametitleId
        {
            get; set;
        }
        public GameTitles Gametitle
        {
            get; set;
        }
        public Matches Matches
        {
            get; set;
        }

    }
}