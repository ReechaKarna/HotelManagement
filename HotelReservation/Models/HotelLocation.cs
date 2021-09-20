using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Models
{
    public class HotelLocation
    {
        [Key()]
       public int HotelLocationId { get; set; }
        public string CityNames { get; set; }
        public int ProvienceNo { get; set; }
        [NotMapped()]
        public int PageSize { get; internal set; }

        [NotMapped()]
        public int PageNumber { get; internal set; }
        [NotMapped()]
        public PagedList.IPagedList<HotelLocation> HotelLocationList { get; internal set; }
    }
}
