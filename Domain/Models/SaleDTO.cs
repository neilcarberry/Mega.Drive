using AutoMapper;
using Domain.AutoMapper;
using Infrastructure.Entities;

namespace Domain.Models
{
    public class SaleDTO : IMap<Sale>
    {
        public int Id { get; set; }
        public int SellerID { get; set; }
        public int AuctioneerId { get; set; }
    }
}