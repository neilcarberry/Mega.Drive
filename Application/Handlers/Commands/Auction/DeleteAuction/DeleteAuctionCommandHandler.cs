using Application.Abstractions;
using Infrastructure.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.Commands
{
    public class DeleteAuctionCommandHandler : BaseHandler<DeleteAuctionCommand, Unit>
    {
        public override Task<Unit> HandleEx(DeleteAuctionCommand request, CancellationToken cancellationToken)
        {

            return Unit.Task;
        }

    }
}
