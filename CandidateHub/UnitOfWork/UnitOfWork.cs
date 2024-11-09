using CandidateHub.Data;
using CandidateHub.Repositories.Interfaces;

namespace CandidateHub.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public ICandidateRepository CandidateRepository { get; }

        public UnitOfWork(ApplicationDbContext context, ICandidateRepository candidateRepository)
        {
            _context = context;
            CandidateRepository = candidateRepository;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}