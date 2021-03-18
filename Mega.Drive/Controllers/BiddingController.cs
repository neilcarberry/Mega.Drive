using API.Controllers;
using Application.Handlers.Queries;
using Microsoft.AspNetCore.Mvc;
using System;
using Application.Handlers.Commands;

namespace Mega.Drive.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BiddingController : BaseController
    {
        [HttpPost, Route("RemoveBid")]
        public IActionResult RemoveBid(DeleteBidCommand command)
        {
            return Ok(Mediator.Send(command));
        }
        //[HttpPost, Route("RemoveBid")]
        //public IActionResult RemoveBid(Guid listingId, BidType bidType, string saleReference, string workOrderReference, string culture = "", string connectionId = "")
        //{
        //    User biddingUser = new UserRepository().GetUser(new Guid(this.User.Identity.GetUserId()), culture, false, true);

        //    if (biddingUser != null)
        //    {
        //        if (bidType == BidType.ProxyBid || bidType == BidType.SealedBid)
        //        {
        //            bool thirdPartySyncResult = true;
        //            bool syncWithThirdParty = ConfigSettingsRepository.GetSettingValue("SimulcastPlaceProxyBids", false);

        //            if (syncWithThirdParty)
        //            {
        //                thirdPartySyncResult = this._proxyBidService.RemoveProxyBid(
        //                    biddingUser.UserName,
        //                    workOrderReference,
        //                    saleReference);
        //            }

        //            // if our sync failed, then we can't place a proxy bid locally
        //            if (!thirdPartySyncResult)
        //            {
        //                // return ok but with failed bid result
        //                return this.Ok(new BidResult { BidStatus = BidStatus.Error, Message = TranslationFunctions.Translate(culture, "Error saving bid", "Error saving bid") });
        //            }

        //            Cache.Remove($"Listings-BiddingRepository.GetBids.{listingId}");

        //            return this.Ok(_biddingRepository.RemoveBid(listingId, biddingUser, bidType, culture));
        //        }

        //        return this.Ok(new BidResult { BidStatus = BidStatus.Error, Message = "Incorrect bid type to remove bid" });
        //    }

        //    return this.Ok(new BidResult { BidStatus = BidStatus.Error, Message = "User not found" });
        //}
    }
}
