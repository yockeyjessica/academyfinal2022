using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcTourney3.Models;

namespace MvcTourney3.Data
{
    public class MvcTourney3Context : DbContext
    {
        public MvcTourney3Context (DbContextOptions<MvcTourney3Context> options)
            : base(options)
        {
        }

        public DbSet<MvcTourney3.Models.Player>? Player { get; set; }

        public DbSet<MvcTourney3.Models.Team>? Team { get; set; }

        public DbSet<MvcTourney3.Models.Tournament> Tournament { get; set; }

        public DbSet<MvcTourney3.Models.GameTitles> GameTitles { get; set; }

        public DbSet<MvcTourney3.Models.Matches> Matches { get; set; }

        public DbSet<MvcTourney3.Models.MatchGames> MatchGames { get; set; }
    }
}
