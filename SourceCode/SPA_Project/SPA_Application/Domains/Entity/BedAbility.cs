using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class BedAbility : TrackEntity
    {
        public long BedId { set; get; }
        public Bed Bed { set; get; }

        public long ServiceId { set; get; }
        public Service Service { set; get; }

    }
}
