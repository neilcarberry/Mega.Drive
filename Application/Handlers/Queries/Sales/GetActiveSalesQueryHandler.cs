using Application.Abstractions;
using Application.Interfaces;
using Domain.Models;
using Infrastructure.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Queries
{
    public class GetActiveSalesQueryHandler : BaseHandler<GetActiveSalesQuery, SaleDTO>
    {
        public override async Task<SaleDTO> HandleEx(GetActiveSalesQuery request, CancellationToken cancellationToken)
        {
           // var auctions = UnitOfWork.AuctionRepository.SingleOrDefaultById(request.Id);
            return Mapper.Map<SaleDTO>(new Sale()); 
        }
    }
}
