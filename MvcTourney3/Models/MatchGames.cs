namespace MvcTourney3.Models
{
    public class MatchGames
    {
        public int Id
        {
            get; set;
        }
        public Team Team1
        {
            get; set;
        }
        public Team Team2
        {
            get; set;
        }
        public string Result
        {
            get; set;
        }
        public int Team1Score
        {
            get; set;
        }
        public int Team2Score
        {
            get; set;
        }
    }
}