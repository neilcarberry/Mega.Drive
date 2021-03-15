using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Extensions
{
    public static class AuctionExtensions
    {
        public static IQueryable<Auction> SpecialQuery(this DbSet<Auction> auctions)
        {
            return auctions.Where(x => x.AuctioneerId == 2);
        }
    }
}
