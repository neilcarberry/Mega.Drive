namespace Infrastructure
{
    using Infrastructure.Entities;
    using Infrastructure.Extensions;
    using Infrastructure.Interfaces;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Storage;

    public class MainDbContext : DbContext, IDbContext
    {
        private IDbContextTransaction _transaction;
        public DbSet<Auction> Auction { get; set; }
        public MainDbContext(DbContextOptions<MainDbContext> options)
            : base(options)
        {
        }
        public void BeginTransaction()
        {
            //_transaction = Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                SaveChanges();
                //_transaction.Commit();
            }
            finally
            {
                //_transaction.Dispose();
            }
        }

        public void Rollback()
        {
            _transaction.Rollback();
            _transaction.Dispose();
        }
    }
}