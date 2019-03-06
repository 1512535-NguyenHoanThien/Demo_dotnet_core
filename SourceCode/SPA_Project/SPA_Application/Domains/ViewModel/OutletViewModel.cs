using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.ViewModel
{
    public class OutletViewModel
    {
        public long Id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Phone{ set; get; }
        public bool Status { set; get; }
        public double Latitude { set; get; }
        public double Longitude { set; get; }
    }
}
