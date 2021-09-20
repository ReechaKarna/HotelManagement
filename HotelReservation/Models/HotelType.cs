using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HotelReservation.Models
{
    public class HotelType
    {
        [Key()]
        public int HotelTypeId { get; set; }
        public string HotelTypeName { get; set; }

        [NotMapped()]
        public int PageSize { get; internal set; }

        [NotMapped()]
        public int PageNumber { get; internal set; }
        [NotMapped()]
        public PagedList.IPagedList<HotelType> HotelList { get; internal set; }

    }
}
