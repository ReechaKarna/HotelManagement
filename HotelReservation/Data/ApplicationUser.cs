using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Data
{
    public class ApplicationUser : IdentityUser
    {
        public int? Userid { get; set; }
    }
}
