using Domain.Interfaces;
using Data.Context;

namespace Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataDbContext _dbContext;
        public UnitOfWork(DataDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Commit()
            => _dbContext.SaveChanges();

        public async Task CommitAsync()
            => await _dbContext.SaveChangesAsync();

        public void Rollback()
            => _dbContext.Dispose();

        public async Task RollbackAsync()
            => await _dbContext.DisposeAsync();
    }
}
