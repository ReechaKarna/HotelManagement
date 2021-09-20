using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Http;
using PagedList.Mvc;

namespace HotelReservation.Models
{
    public class Hotel
    {
        [Key()]
        public int HotelId { get; set; }
        [DisplayName("Hotel Name")]
        public string HotelName { get; set; }
        [DisplayName("Hotel Type")]
        public int HotelTypeId { get; set; }
        public HotelType HotelType { get; set; }
        [DisplayName("Hotel Location")]
        public int HotelLocationId { get; set; }
        public  HotelLocation HotelLocation { get; set; }
        [NotMapped()]
        public int PageSize { get; internal set; }

        [NotMapped()]
        public int PageNumber { get; internal set; }
        [NotMapped()]
        public PagedList.IPagedList<Hotel> HotelList { get; internal set; }




        [DisplayName("Hotel's Image")]
        public Byte[] Image { get; set; }

        [NotMapped()]
        public IFormFile ImageFile { get; set; }


    }
}
