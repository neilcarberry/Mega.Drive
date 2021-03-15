using Application.Abstractions;
using Domain.Models;
using Infrastructure.Entities;
using MediatR;

namespace Application.Handlers.Commands
{
    public class AddAuctionCommand : BaseRequest<Unit>
    {
        public AuctionDTO AuctionDTO { get; set; }
        public override string CacheKey { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
