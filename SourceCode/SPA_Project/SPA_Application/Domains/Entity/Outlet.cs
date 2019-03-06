using SPA_Application.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Entity
{
    public class Outlet : TrackEntity
    {
        public long Id { set; get; }

        public string Name { set; get; }
        public string Address { set; get; }
        public string Phone { set; get; }
        public double Latitude { set; get; }
        public double Longitude { set; get; }
        
        public ICollection<Appointment> Appointments { set; get; }
        public ICollection<OutletAbility> OutletAbilities { set; get; }
    }
}
