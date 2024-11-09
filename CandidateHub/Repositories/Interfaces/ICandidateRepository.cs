using CandidateHub.Models;

namespace CandidateHub.Repositories.Interfaces
{
    public interface ICandidateRepository
    {
        Task<Candidate> GetCandidateByEmailAsync(string email);
        Task AddCandidateAsync(Candidate candidate);
        Task UpdateCandidateAsync(Candidate candidate);
        Task SaveChangesAsync();
    }
}
