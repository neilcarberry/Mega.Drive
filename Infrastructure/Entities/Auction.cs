using Infrastructure.Interfaces;

namespace Infrastructure.Entities
{
    public class Auction : BaseEntity
    {
        public int Id { get; set; }
        public int SellerID { get; set; }
        public int AuctioneerId { get; set; }
    }
}
