using System;
using Application.Abstractions;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Application.Handlers.Queries
{
    public class GetActiveSalesQuery : BaseRequest<SaleDTO>
    {
        [FromRoute]
        public string Culture { get; set; }

        public override string CacheKey { get { return "GetActiveSales"; } }
    }
}
