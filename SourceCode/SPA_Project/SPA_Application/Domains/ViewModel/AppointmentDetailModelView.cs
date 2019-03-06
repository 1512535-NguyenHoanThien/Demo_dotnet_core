using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.ViewModel
{
    public class AppointmentDetailModelView
    {
        public int Order { set; get; }
        public string ServiceName { set; get; }
        public DateTime StartTime { set; get; }
        public DateTime FinishTime { set; get; }
    }
}
