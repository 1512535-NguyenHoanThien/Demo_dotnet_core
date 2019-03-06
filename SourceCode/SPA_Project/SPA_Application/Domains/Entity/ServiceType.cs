using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class ServiceType : TrackEntity
    {
        public int Id { set; get; }
        public string ServiceName { set; get; }
        public string ImageUrl { set; get; }

        public ICollection<Service> Services { set; get; }
    }
}
