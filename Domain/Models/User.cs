using AutoMapper;

namespace Domain.Models
{
    #region Usings

    using System;
    using System.Collections.Generic;
    using AutoMapper;

    #endregion

    /// <summary>
    /// The user.
    /// </summary>
    public class User : IHaveCustomMapping
    {

        #region Properties       

        /// <summary>
        /// Gets or sets the activity history.
        /// </summary>
        /// <value>
        /// The activity history.
        /// </value>
        //public List<ActivityHistory> ActivityHistory { get; set; }

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
        /// Gets or sets the client identifier.
        /// </summary>
        /// <value>
        /// The client identifier.
        /// </value>
        //[TranslationRequired(ErrorMessage = "The Acc No selection is required")]
        public Guid? ClientId { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        //[TranslationRequired(ErrorMessage = "The Confirm Password field is required")]
        public string ConfirmPassword { get; set; }

        /// <summary>
        /// Gets or sets the created date.
        /// </summary>
        /// <value>
        /// The created date.
        /// </value>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Gets or sets the created user user identifier.
        /// </summary>
        /// <value>
        /// The created user identifier.
        /// </value>
        public Guid? CreatedUserId { get; set; }

        /// <summary>
        /// Gets or sets the name of the created user.
        /// </summary>
        /// <value>
        /// The name of the created user.
        /// </value>
        public string CreatedUserName { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="User"/> is deleted.
        /// </summary>
        /// <value>
        /// <c>true</c> if deleted; otherwise, <c>false</c>.
        /// </value>
        public bool Deleted { get; set; }

        /// <summary>
        /// Access expiry date for user access
        /// </summary>
        public DateTime? ExpiryDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [internal user].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [internal user]; otherwise, <c>false</c>.
        /// </value>
        public bool InternalUser { get; set; }

        /// <summary>
        /// Gets or sets the last login date.
        /// </summary>
        /// <value>
        /// The last login date.
        /// </value>
        public DateTime LastLoginDate { get; set; }

        /// <summary>
        /// Gets or sets the modified date.
        /// </summary>
        /// <value>
        /// The modified date.
        /// </value>
        public DateTime ModifiedDate { get; set; }

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
        public Guid RegistrationId { get; set; }

        /// <summary>
        /// Gets or sets the status.
        /// </summary>
        /// <value>
        /// The status.
        /// </value>
        public int Status { get; set; }

        /// <summary>
        /// Gets or sets the user groups.
        /// </summary>
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
        /// Gets or sets the roles.
        /// </summary>
        /// <value>
        /// The roles.
        /// </value>
        //public ICollection<UserRole> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [internal user].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [view only]; otherwise, <c>false</c>.
        /// </value>
        public bool ViewOnly { get; set; }

        #endregion

        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Infrastructure.Entities.User, User>()
                .ForMember(destination => destination.UserId,
                    opts => opts.MapFrom(source => source.UserId))
                .ForMember(destination => destination.UserName,
                    opts => opts.MapFrom(source => source.UserName))
                .ForMember(destination => destination.RegistrationId,
                    opts => opts.MapFrom(source => source.RegistrationId))
                .ForMember(destination => destination.ClientId,
                    opts => opts.MapFrom(source => source.ClientId))
                .ForMember(destination => destination.Deleted,
                    opts => opts.MapFrom(source => source.Deleted))
                .ForMember(destination => destination.Status,
                    opts => opts.MapFrom(source => source.Status))
                .ForMember(destination => destination.ExpiryDate,
                    opts => opts.MapFrom(source => source.ExpiryDate))
                .ForMember(destination => destination.Password,
                    opts => opts.MapFrom(source => source.Password))
                .ForMember(destination => destination.LastLoginDate,
                    opts => opts.MapFrom(source => source.LastLoginDate))
                .ForMember(destination => destination.CreatedDate,
                    opts => opts.MapFrom(source => GetLocalDate(source.CreatedDate))).ReverseMap();

            //if (displayLocalTime)
            //{
            //    // need to calculate time as being called from .NET
            //    this.CreatedDate = DateConversion.GetLocalDate(user.CreatedDate);

            //    if (user.LastLoginDate.HasValue)
            //    {
            //        this.LastLoginDate = DateConversion.GetLocalDate(user.LastLoginDate.Value);
            //    }
            //}
            //else
            //{
            //    // display "as is" i.e. UTC time, javascript will work out the rest
            //    this.CreatedDate = user.CreatedDate;

            //    if (user.LastLoginDate.HasValue)
            //    {
            //        this.LastLoginDate = user.LastLoginDate.Value;
            //    }
            //}


            //if (user.UserRoles != null)
            //{
            //    this.UserRoles = user.UserRoles.Where(i => !i.Role.Deleted).Select(ur => new UserRole(ur, culture)).ToList();
            //}

            //if (user.UserGroups != null)
            //{
            //    this.UserGroups = user.UserGroups.Select(ur => new UserGroup(ur, culture)).ToList();
            //}

            //// TODO: Client isn't being populated.
            //if (user.Client != null)
            //{
            //    this.Client = new Client(user.Client, culture);
            //}

            //if (user.ClientContact != null)
            //{
            //    this.ClientContact = new ClientContact(user.ClientContact, culture);
            //}

            //if (user.Registration != null)
            //{
            //    this.Registration = new Registration(user.Registration, culture, displayLocalTime);
            //}

            //if (user.ActivityHistory != null)
            //{
            //    this.ActivityHistory = user.ActivityHistory.Select(a => new ActivityHistory(a, culture)).ToList();
            //}


            //UserId = user.UserId;
            //UserName = user.UserName;
            //RegistrationId = user.RegistrationId ?? new Guid();
            //ClientId = user.ClientId ?? new Guid();
            //Deleted = user.Deleted;
            //Status = user.Status;
            //ExpiryDate = user.ExpiryDate;



        }

        private DateTime GetLocalDate(DateTime createdDate)
        {
            return DateTime.Now;
        }
    }
}