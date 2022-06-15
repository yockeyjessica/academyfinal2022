namespace MvcTourney3.Models
{
    public class Tournament
    {
        public int Id
        {
            get; set;
        }
        public string? Season
        {
            get; set;
        }
        public GameTitles Gametitle
        {
            get; set;
        }

    }
}