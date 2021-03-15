

namespace Infrastructure.Interfaces
{
    using Infrastructure.Entities;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    public interface IDbContext
    {
        DbSet<Auction> Auction { get; }

        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
