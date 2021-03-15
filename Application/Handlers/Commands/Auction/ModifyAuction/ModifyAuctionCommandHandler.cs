using Application.Abstractions;
using Application.Interfaces;
using Infrastructure.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Commands
{
    public class ModifyAuctionCommandHandler : BaseHandler<ModifyAuctionCommand,Unit>
    {
        public override Task<Unit> HandleEx(ModifyAuctionCommand request, CancellationToken cancellationToken)
        {

            return Unit.Task;
        }
    }
}
