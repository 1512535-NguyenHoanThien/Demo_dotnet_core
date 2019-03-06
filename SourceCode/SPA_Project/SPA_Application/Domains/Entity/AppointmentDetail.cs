using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class AppointmentDetail : TrackEntity
    {
        public int Order { set; get; }

        public long AppointmentId { set; get; }
        public Appointment Appointment { set; get; }

        public long ServiceId { set; get; }
        public Service Service { set; get; }

        public long BedId { set; get; }
        public Bed Bed { set; get; }

        public DateTime StartTime { set; get; }
        public DateTime FinishTime { set; get; }
    }
}
