using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Domains.Service.IService
{
    public interface IAppointmentService
    {
        IEnumerable<AppointmentViewModel> GetAppointments(string Id);
        IEnumerable<AppointmentViewModel> GetAppointmentsById(long id);
        IEnumerable<AppointmentViewModel> GetAppointmentsByStatus(AppointmentStatus status);
        string Booking(BookingViewModel booking);
        IEnumerable<AppointmentDetailModelView> GetAppointmentDetails(int appointmentId);
    }
}
