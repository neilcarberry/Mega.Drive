using Application.Abstractions;
using Application.Interfaces;
using Domain.Models;
using Infrastructure.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Queries
{
    public class GetAuctionsQueryHandler : BaseHandler<GetAuctionsQuery, List<AuctionDTO>>
    {
        public override async Task<List<AuctionDTO>> HandleEx(GetAuctionsQuery request, CancellationToken cancellationToken)
        {
            var auctions = DbContext.Auction.Where(x => x.AuctioneerId == 2);
            return Mapper.Map<List<AuctionDTO>>(auctions);
        }
    }
}
