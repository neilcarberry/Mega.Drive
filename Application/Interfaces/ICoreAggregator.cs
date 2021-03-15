using AutoMapper;
using Infrastructure.CacheInterfaces;
using Infrastructure.Interfaces;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Interfaces
{
    public interface ICoreAggregator
    {
        ILoggerFactory Logger { get; set; }
        IDbContext DbContext { get; set; }
        IMediator Mediator { get; set; }
        IMapper Mapper { get; set; }
        ICache Cache { get; set; }
    }
}
