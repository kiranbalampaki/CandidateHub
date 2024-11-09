using CandidateHub.Models;
using Microsoft.EntityFrameworkCore;

namespace CandidateHub.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Candidate> Candidates { get; set; }
    }
}