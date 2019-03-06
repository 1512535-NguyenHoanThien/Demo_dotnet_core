using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Entity
{
    public class Bed : TrackEntity
    {
        public long Id { set; get; }

        public Status Status { set; get; }
        public string ExtraNote { set; get; }

        public ICollection<AppointmentDetail> AppointmentDetails { set; get; }

        public long RoomId { set; get; }
        public Room Room { set; get; }
    }
}
