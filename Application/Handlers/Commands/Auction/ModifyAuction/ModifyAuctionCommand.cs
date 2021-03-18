using System;
using Application.Abstractions;
using Domain.Models;
using Infrastructure.Entities;
using MediatR;

namespace Application.Handlers.Commands
{
    public class ModifyAuctionCommand : BaseRequest<Unit>
    {
        public AuctionDTO AuctionModifier { get; set; }
        public override string CacheKey { get; }
    }
}
