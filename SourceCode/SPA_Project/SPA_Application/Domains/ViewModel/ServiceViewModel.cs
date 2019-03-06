using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.ViewModel
{
    public class ServiceViewModel
    {
        public long Id { set; get; }

        public string ServiceName { set; get; }
        public long Price { set; get; }
        public string Content { set; get; }
        public int Time { set; get; }

        public string ImgUrl { set; get; }
        public int ServiceTypeId { set; get; }
    }
}
