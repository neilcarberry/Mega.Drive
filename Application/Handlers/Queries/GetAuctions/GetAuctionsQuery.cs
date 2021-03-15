using Application.Abstractions;
using Application.Interfaces;
using Domain.Models;
using Infrastructure.Entities;
using MediatR;
using System.Collections.Generic;

namespace Application.Handlers.Queries
{
    public class GetAuctionsQuery : BaseRequest<List<AuctionDTO>>
    {
        public int Id { get; set; }
        public override string CacheKey { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
