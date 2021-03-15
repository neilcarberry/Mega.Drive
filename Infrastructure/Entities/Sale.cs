using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;

namespace Infrastructure.Entities
{
    public class Sale 
    {
        public byte? Active { get; set; }

        //public ICollection<BidIncrement> BidIncrements { get; set; }

        public string CatalogueNote { get; set; }

        public string Code { get; set; }
        public string Description { get; set; }

        public string DescriptionDisplay { get; set; }

        public DateTime? EndDate { get; set; }

        public int? ExtendAuctionByMins { get; set; }

        public int? ExtendAuctionIfBidWithinMins { get; set; }

        public DateTime? ExtendedEndDate { get; set; }

        public DateTime? FirstListingEndDate { get; set; }

        public byte? ForceLive { get; set; }

        public string Icon { get; set; }

        public bool? IsLiveBid { get; set; }

        public int? Lane { get; set; }

        //public ICollection<Lane> Lanes { get; set; }

        //public ICollection<Listing> Listings { get; set; }

        //public Location Location { get; set; }

        public int LocationId { get; set; }

        public string NoteDisplay { get; set; }

        public string Notes { get; set; }

        public DateTime? OpenDate { get; set; }

        //public SaleAdditional SaleAdditional { get; set; }

        //public ICollection<SaleGroup> SaleGroups { get; set; }

        public int SaleId { get; set; }

        //public SalesChannel SalesChannel { get; set; }

        public int SalesChannelId { get; set; }

        //public SalesChannelType SalesChannelType { get; set; }

        public int? SalesChannelTypeId { get; set; }

        public int? SaleSubType { get; set; }

        //public SaleType SaleType { get; set; }

        public int SaleTypeId { get; set; }

        public bool? ShowCapData { get; set; }

        public byte Status { get; set; }

        public string SaleUrl { get; set; }

        public byte? TimedAuctionState { get; set; }

    }
}
