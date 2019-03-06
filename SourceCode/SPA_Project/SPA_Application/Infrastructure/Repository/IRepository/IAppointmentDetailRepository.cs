using SPA_Application.Domains.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Infrastructure.Repository.IRepository
{
    public interface IAppointmentDetailRepository
    {
        void AddAppointmentDetail(BookingViewModel booking, long appointmentId);
        IEnumerable<AppointmentDetailModelView> GetAppointmentDetails(int appointmentId);
    }
}
