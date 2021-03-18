using Application.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Handlers.Commands
{
    public class DeleteAuctionCommand : BaseRequest<Unit>
    {
        public int Id { get; set; }
        public override string CacheKey { get; }
    }
}
