using Application.Abstractions;
using Application.Interfaces;
using Domain.Models;
using Infrastructure.Entities;
using MediatR;

namespace Application.Handlers.Queries
{
    public class GetAuctionQuery : BaseRequest<AuctionDTO>
    {
        public int Id { get; set; }
        public override string CacheKey { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
