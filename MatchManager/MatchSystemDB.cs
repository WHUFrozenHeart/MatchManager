using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MatchManager
{
    public class MatchSystemDB : DbContext
    {
        public DbSet<Player> players { get; set; }
        public DbSet<Team> teams { get; set; }
        public DbSet<Match> matches { get; set; }
        public DbSet<PlayerMatch> playerMatches { get; set; }
        public DbSet<Leader> leaders { get; set; }
        public DbSet<Coach> coaches { get; set; }
        public DbSet<Doctor> doctors { get; set; }
        public DbSet<Referee> referees { get; set; }
        public DbSet<Group> groups { get; set; }
        public DbSet<RefereeGroup> refereeGroups { get; set; }
        public DbSet<File> files { get; set; }

        public MatchSystemDB() : base("MatchSystemDataBase")
        {

        }
    }
}
