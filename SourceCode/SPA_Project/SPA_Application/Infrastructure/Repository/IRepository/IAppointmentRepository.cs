using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPA_Application.Domains.ViewModel;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Infrastructure.Repository.IRepository
{
    public interface IAppointmentRepository
    {
        IEnumerable<AppointmentViewModel> GetAppointments(string Id);
        IEnumerable<AppointmentViewModel> GetAppointmentsById(long id);
        IEnumerable<AppointmentViewModel> GetAppointmentsByStatus(AppointmentStatus status);
        long AddNewAppointment(BookingViewModel booking);
    }
}
