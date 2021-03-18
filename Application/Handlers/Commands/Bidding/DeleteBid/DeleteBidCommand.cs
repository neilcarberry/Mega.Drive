using Application.Abstractions;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using Domain.Models;
using Newtonsoft.Json;

namespace Application.Handlers.Commands
{
    public class DeleteBidCommand : BaseRequest<BidResult>
    {
        public Guid ListingId { get; set; }
        //BidType bidType; string saleReference; 
        public string WorkOrderReference { get; set; }
        public string Culture { get; set; }
        public string ConnectionId { get; set; }

        public override string CacheKey
        {
            get
            {
                return $"Listings-BiddingRepository.GetBids.{ListingId}";
            }
        }
    }
}
