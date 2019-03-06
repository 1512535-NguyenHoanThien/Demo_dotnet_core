using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Entity
{
    public class Appointment : TrackEntity
    {
        public long Id { set; get; }

        public DateTime DateBooked { set; get; }
        public int TotalTime { set; get; }
        public long TotalPrice { set; get; }
        public bool IsPaid { set; get; }
        public string ExtraNote { set; get; }
        public AppointmentStatus Status { set; get; }

        //public List<Service> Services { set; get; }

        public ICollection<AppointmentDetail> AppointmentDetails { set; get; }

        public long OutletId { set; get; }
        public Outlet Outlet { set; get; }

        public string UserId { set; get; }
        public User User { set; get; }

        public string TherapistId { set; get; }
        //public User Therapist { set; get; }

        public Result Result { set; get; }
    }
}
