using System;
using Application.Abstractions;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;

namespace Application.Handlers.Commands
{
    public class DeleteBidCommandHandler : BaseHandler<DeleteBidCommand, BidResult>
    {
        public override Task<BidResult> HandleEx(DeleteBidCommand request, CancellationToken cancellationToken)
        {
            Infrastructure.Entities.User gh = new Infrastructure.Entities.User()
            { CreatedDate = DateTime.Now.AddDays(-10) };
            User d = Mapper.Map<User>(gh);

            //User biddingUser = new UserRepository().GetUser(new Guid(this.User.Identity.GetUserId()), culture, false, true);

            //if (biddingUser != null)
            //{
            //    if (bidType == BidType.ProxyBid || bidType == BidType.SealedBid)
            //    {
            //        bool thirdPartySyncResult = true;
            //        bool syncWithThirdParty = ConfigSettingsRepository.GetSettingValue("SimulcastPlaceProxyBids", false);

            //        if (syncWithThirdParty)
            //        {
            //            thirdPartySyncResult = this._proxyBidService.RemoveProxyBid(
            //                biddingUser.UserName,
            //                workOrderReference,
            //                saleReference);
            //        }

            //        // if our sync failed, then we can't place a proxy bid locally
            //        if (!thirdPartySyncResult)
            //        {
            //            // return ok but with failed bid result
            //            return new BidResult { BidStatus = BidStatus.Error, Message = TranslationFunctions.Translate(culture, "Error saving bid", "Error saving bid") };
            //        }

            //        Cache.Remove($"Listings-BiddingRepository.GetBids.{listingId}");

            //        return _biddingRepository.RemoveBid(listingId, biddingUser, bidType, culture);
            //    }

            //    return new BidResult { BidStatus = BidStatus.Error, Message = "Incorrect bid type to remove bid" };
            //}

            //return new BidResult { BidStatus = BidStatus.Error, Message = "User not found" };

            return Task.FromResult(new BidResult());
        }

    }
}
