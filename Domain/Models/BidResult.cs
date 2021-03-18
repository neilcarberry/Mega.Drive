namespace Domain.Models
{
    #region Usings

    using System;

    #endregion

    /// <summary>
    /// The bid result.
    /// </summary>
    public class BidResult
    {
        #region Properties

        /// <summary>
        /// Gets or sets the bid amount.
        /// </summary>
        /// <value>
        /// The bid amount.
        /// </value>
        public decimal BidAmount { get; set; }

        /// <summary>
        /// Gets or sets the bid status.
        /// </summary>
        /// <value>
        /// The bid status.
        /// </value>
        //public BidStatus BidStatus { get; set; }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime EndDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [end extension].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [end extension]; otherwise, <c>false</c>.
        /// </value>
        public bool EndExtension { get; set; }

        /// <summary>
        /// Gets or sets the end time full.
        /// </summary>
        /// <value>
        /// The end time full.
        /// </value>
        public double EndTimeFull { get; set; }

        /// <summary>
        /// Gets or sets the listing identifier.
        /// </summary>
        /// <value>
        /// The listing identifier.
        /// </value>
        public Guid ListingId { get; set; }

        /// <summary>
        /// Gets or sets the listing status.
        /// </summary>
        /// <value>
        /// The listing status.
        /// </value>
        //public ListingStatus ListingStatus { get; set; }

        /// <summary>
        /// Gets or sets the maximum bid.
        /// </summary>
        /// <value>
        /// The maximum bid.
        /// </value>
        public decimal? MaxBid { get; set; }

        /// <summary>
        /// Gets or sets the message.
        /// </summary>
        /// <value>
        /// The message.
        /// </value>
        public string Message { get; set; }

        /// <summary>
        /// Gets or sets the minimum bid.
        /// </summary>
        /// <value>
        /// The minimum bid.
        /// </value>
        public decimal? MinimumBid { get; set; }

        /// <summary>
        /// Gets or sets the number of bids.
        /// </summary>
        /// <value>
        /// The number of bids.
        /// </value>
        public int NumberOfBids { get; set; }

        /// <summary>
        /// Gets or sets the remaining time.
        /// </summary>
        /// <value>
        /// The remaining time.
        /// </value>
        public double RemainingTime { get; set; }

        /// <summary>
        /// Gets or sets the time now.
        /// </summary>
        /// <value>
        /// The time now.
        /// </value>
        public double TimeNow { get; set; }

        /// <summary>
        /// Gets or sets the user identifier.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public Guid UserId { get; set; }

        public string UserName { get; set; }

        /// <summary>
        /// Gets or set the Work Order identifier
        /// </summary>
        /// <value>
        /// The Work Order Identifier
        /// </value>
        public Guid? WorkOrderId { get; set; }

        #endregion
    }
}
