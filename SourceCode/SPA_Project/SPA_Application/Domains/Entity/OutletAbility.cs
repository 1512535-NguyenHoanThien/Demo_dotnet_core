using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class OutletAbility : TrackEntity
    {
        public long ServiceId { set; get; }
        public Service Service { set; get; }

        public long OutletId { set; get; }
        public Outlet Outlet { set; get; }
    }
}
