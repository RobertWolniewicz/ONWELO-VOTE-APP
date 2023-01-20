using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONWELO_VOTE_APP.Entity
{
    public class VoteAppDB : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Voter> Voters { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           var appPath = Path.GetDirectoryName(Application.StartupPath);
           var dbPath = Path.Combine(appPath, "ONWELO VOTE APP.db");
           optionsBuilder.UseSqlite("Data Source=" + dbPath);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Voter>(eb =>
            {
                eb.Property(V => V.AmountOfCandidats).HasDefaultValue(3);
                eb.Property(V => V.HasVoted).HasDefaultValue(false);
            });
            modelBuilder.Entity<Candidate>(eb =>
            {
                eb.Property(C => C.Votes).HasDefaultValue(0);
            });
        }
    }
}
