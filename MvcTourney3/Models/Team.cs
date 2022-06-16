namespace MvcTourney3.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        //THE FOLLOWING IS ESSENTIAL FOR JOINING TABLES
        public int GametitleId
        {
            get; set;
        }
        public GameTitles Gametitle
        {
            get; set;
        }
        public string School { get; set; }

        public List<Player> Players { get; set; } /*= new List<Player>();*/

    }
}
