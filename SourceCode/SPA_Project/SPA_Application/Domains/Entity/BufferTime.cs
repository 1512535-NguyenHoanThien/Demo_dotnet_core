using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class BufferTime : TrackEntity
    {
        public int Time { set; get; }

        public string TherapistId { set; get; }
        public User Therapist { set; get; }

        public long ServiceId { set; get; }
        public Service Service { set; get; }
    }
}
