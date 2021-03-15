using API.Controllers;
using Application.Handlers.Commands;
using Infrastructure;
using Infrastructure.Entities;
using Infrastructure.Extensions;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mega.Drive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : BaseController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDbContext dbContext)
        {
            _logger = logger;
            dbContext1 = dbContext;
        }

        public IDbContext dbContext1 { get; }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
            Mediator.Send(new AddAuctionCommand() { AuctionDTO = new Domain.Models.AuctionDTO() { AuctioneerId = 1, Id = 1, SellerID = 1 } });
            var g = dbContext1.Auction.SpecialQuery();
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
