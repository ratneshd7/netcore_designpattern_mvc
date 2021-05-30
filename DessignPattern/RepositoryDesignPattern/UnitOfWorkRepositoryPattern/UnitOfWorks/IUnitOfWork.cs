using Microsoft.EntityFrameworkCore;

namespace UnitOfWorkRepositoryPattern.UnitOfWorks
{
    public interface IUnitOfWork
    {
        DbContext Context { get; }
        void Save();
    }
}
