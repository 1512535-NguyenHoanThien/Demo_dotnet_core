using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class StaffManager
    {
        public long Id { set; get; }

        public string UserId { set; get; }
        public User User { set; get; }

        public long OutletId { set; get; }
        public Outlet Outlet { set; get; }
    }
}
