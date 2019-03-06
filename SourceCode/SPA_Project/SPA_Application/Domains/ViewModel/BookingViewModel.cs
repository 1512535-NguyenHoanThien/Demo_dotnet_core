using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.ViewModel
{
    public class BookingViewModel
    {
        public string UserId { set; get; }
        public string Therapit { set; get; }
        public long OutletId { set; get; }
        public DateTime DatetimeBooked { set; get; }
        public int TotalPrice { set; get; }
        public int TotalTime { set; get; }
        public List<long> Services { set; get; }

    }
}
