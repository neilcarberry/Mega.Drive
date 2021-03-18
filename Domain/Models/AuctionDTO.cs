namespace Domain.Models
{
    using AutoMapper;
    using Infrastructure.Entities;

    public class AuctionDTO : IMap<Auction>
    {
        public int Id { get; set; }
        public int SellerID { get; set; }
        public int AuctioneerId { get; set; }
    }
}