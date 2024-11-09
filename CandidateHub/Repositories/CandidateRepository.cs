using CandidateHub.Data;
using CandidateHub.Models;
using CandidateHub.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace CandidateHub.Repositories
{
    public class CandidateRepository : ICandidateRepository
    {
        private readonly ApplicationDbContext _context;

        public CandidateRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Candidate> GetCandidateByEmailAsync(string email)
        {
            return await _context.Candidates.FirstOrDefaultAsync(c => c.Email == email);
        }

        public async Task AddCandidateAsync(Candidate candidate)
        {
            await _context.Candidates.AddAsync(candidate);
        }

        public Task UpdateCandidateAsync(Candidate candidate)
        {
            _context.Candidates.Update(candidate);
            return Task.CompletedTask;
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
