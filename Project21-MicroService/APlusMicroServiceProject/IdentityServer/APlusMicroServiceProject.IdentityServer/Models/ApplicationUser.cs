﻿using Microsoft.AspNetCore.Identity;

namespace APlusMicroServiceProject.IdentityServer.Models
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public string UserImage { get; set; }
        public string UserDistrict { get; set; }
        public string UserCity { get; set; }
        public string UserCountry { get; set; }
    }
}
