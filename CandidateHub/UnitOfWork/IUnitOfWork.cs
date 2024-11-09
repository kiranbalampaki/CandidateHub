using CandidateHub.Repositories.Interfaces;

namespace CandidateHub.UnitOfWork
{
    public interface IUnitOfWork
    {
        ICandidateRepository CandidateRepository { get; }
        Task CompleteAsync();
    }
}
