using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.ViewModel
{
    public class AppointmentViewModel
    {
        public long Id { set; get; }

        public DateTime DateBooked { set; get; }
        public int TotalTime { set; get; }
        public long TotalPrice { set; get; }
        public bool IsPaid { set; get; }
        public string ExtraNote { set; get; }
        public EntityHelper.AppointmentStatus Status { set; get; }
        public string TherapistName { set; get; }
        public string OutletName { set; get; }
    }
}
