namespace Infrastructure.Entities
{

    #region Usings

    using System;
    using System.Collections.Generic;

    #endregion

    /// <summary>
    /// The user.
    /// </summary>
    public class User
    {
        #region Properties

        /// <summary>
        /// Gets or sets the activity histories.
        /// </summary>
        /// <value>
        /// The activity history.
        /// </value>
        //public ICollection<ActivityHistory> ActivityHistory { get; set; }

        /// <summary>
        /// Gets or sets the admin bid histories.
        /// </summary>
        /// <value>
        /// The admin bid histories.
        /// </value>
        //public ICollection<BidHistory> AdminBidHistories { get; set; }

        /// <summary>
        /// Gets or sets the assets.
        /// </summary>
        /// <value>
        /// The assets.
        /// </value>
        //public ICollection<Asset> Assets { get; set; }

        /// <summary>
        /// Gets or sets the bid histories.
        /// </summary>
        /// <value>
        /// The bid histories.
        /// </value>
        //public ICollection<BidHistory> BidHistories { get; set; }

        /// <summary>
        /// Gets or sets the buy now histories.
        /// </summary>
        /// <value>
        /// The buy now histories.
        /// </value>
        //public ICollection<BuyNowHistory> BuyNowHistories { get; set; }

        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        /// <value>
        /// The client.
        /// </value>
        //public Client Client { get; set; }

        /// <summary>
        /// Gets or sets the client contact.
        /// </summary>
        /// <value>
        /// The client contact.
        /// </value>
        //public ClientContact ClientContact { get; set; }

        /// <summary>
        /// Gets or sets the client contact identifier.
        /// </summary>
        /// <value>
        /// The client contact identifier.
        /// </value>
        public Guid? ClientContactId { get; set; }

        /// <summary>
        /// Gets or sets the client id.
        /// </summary>
        /// <value>
        /// The client identifier.
        /// </value>
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comment list.
        /// </value>
        //public ICollection<Comment> CommentList { get; set; }

        /// <summary>
        /// Gets or sets the comments.
        /// </summary>
        /// <value>
        /// The comments.
        /// </value>
        //public ICollection<Comment> Comments { get; set; }

        /// <summary>
        /// Gets or sets the contact messages.
        /// </summary>
        /// <value>
        /// The contact messages.
        /// </value>
        //public ICollection<ContactMessage> ContactMessages { get; set; }

        /// <summary>
        /// Gets or sets the created activity histories.
        /// </summary>
        /// <value>
        /// The created activity history.
        /// </value>
        //public ICollection<ActivityHistory> CreatedActivityHistory { get; set; }

        /// <summary>
        /// Gets or sets the created clients.
        /// </summary>
        /// <value>
        /// The created clients.
        /// </value> 
        //public ICollection<Client> CreatedClients { get; set; }

        /// <summary>
        /// Gets or sets the date created.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created notifications.
        /// </summary>
        /// <value>
        /// The created notifications.
        /// </value>
        //public ICollection<Notification> CreatedNotifications { get; set; }

        /// <summary>
        /// Gets or sets the created user.
        /// </summary>
        /// <value>
        /// The created user.
        /// </value>
        public User CreatedUser { get; set; }

        /// <summary>
        /// Gets or sets the created user id.
        /// </summary>
        /// <value>
        /// The created user identifier.
        /// </value>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// Gets or sets the created user roles.
        /// </summary>
        /// <value>
        /// The created user roles.
        /// </value>
        //public ICollection<UserRole> CreatedUserRoles { get; set; }

        /// <summary>
        /// Gets or sets the created users.
        /// </summary>
        /// <value>
        /// The created users.
        /// </value>
        public ICollection<User> CreatedUsers { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether deleted.
        /// </summary>
        /// <value>
        ///   <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the devices.
        /// </summary>
        /// <value>
        /// The devices.
        /// </value>
        //public ICollection<Device> Devices { get; set; }

        /// <summary>
        /// Access expiry date for user access
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets the group list.
        /// </summary>
        /// <value>
        /// The group list.
        /// </value>
        //public ICollection<Group> GroupList { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [internal user].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [internal user]; otherwise, <c>false</c>.
        /// </value>
        public bool InternalUser { get; set; }

        /// <summary>
        /// Gets or sets the last login.
        /// </summary>
        /// <value>
        /// The last login date.
        /// </value>
        public DateTime? LastLoginDate { get; set; }

        /// <summary>
        /// Gets or sets the listings.
        /// </summary>
        /// <value>
        /// The listings.
        /// </value>
        //public ICollection<Listing> Listings { get; set; }

        /// <summary>
        /// Gets or sets the listing status histories.
        /// </summary>
        /// <value>
        /// The listing status histories.
        /// </value>
        //public ICollection<ListingStatusHistory> ListingStatusHistories { get; set; }

        /// <summary>
        /// Gets or sets the date modified.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Gets or sets the notifications.
        /// </summary>
        /// <value>
        /// The notifications.
        /// </value>
        //public ICollection<Notification> Notifications { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; }

        /// <summary>
        /// Gets or sets the registration.
        /// </summary>
        /// <value>
        /// The registration.
        /// </value>
        //public Registration Registration { get; set; }

        /// <summary>
        /// Gets or sets the registration identifier.
        /// </summary>
        /// <value>
        /// The registration identifier.
        /// </value>
        public Guid? RegistrationId { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the user needs to reset their password.
        /// </summary>
        /// <value>
        ///   <c>true</c> if [reset password]; otherwise, <c>false</c>.
        /// </value>
        public bool RequirePasswordReset { get; set; }

        /// <summary>
        /// Gets or sets the role privileges.
        /// </summary>
        /// <value>
        /// The role privileges.
        /// </value>
        //public ICollection<RolePrivilege> RolePrivileges { get; set; }

        /// <summary>
        /// Gets or sets the Saved Searches.
        /// </summary>
        /// <value>
        /// The saved searches.
        /// </value>
        //public ICollection<SavedSearch> SavedSearches { get; set; }

        /// <summary>
        /// Stores the source of the user
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the user groups.
        /// </summary>
        /// <value>
        /// The user groups.
        /// </value>
        //public ICollection<UserGroup> UserGroups { get; set; }

        /// <summary>
        /// Gets or sets the user id.
        /// </summary>
        /// <value>
        /// The user identifier.
        /// </value>
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The name of the user.
        /// </value>
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the user roles.
        /// </summary>
        /// <value>
        /// The user roles.
        /// </value>
        //public ICollection<UserRole> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets the vehicles.
        /// </summary>
        /// <value>
        /// The vehicles.
        /// </value>
        //public ICollection<Vehicle> Vehicles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [view only].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [view only]; otherwise, <c>false</c>.
        /// </value>
        public bool ViewOnly { get; set; }

        /// <summary>
        /// Gets or sets the watch lists.
        /// </summary>
        /// <value>
        /// The watch lists.
        /// </value>
        //public ICollection<WatchList> WatchLists { get; set; }

        /// <summary>
        /// Gets or sets the work orders.
        /// </summary>
        /// <value>
        /// The work orders.
        /// </value>
        //public ICollection<WorkOrder> WorkOrders { get; set; }

        #endregion

    }
}
