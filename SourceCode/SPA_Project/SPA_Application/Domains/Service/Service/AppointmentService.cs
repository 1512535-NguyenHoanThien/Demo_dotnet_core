using SPA_Application.Common;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Domains.ViewModel;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Domains.Service.Service
{
    public class AppointmentService : IAppointmentService
    {

        private IAppointmentRepository _appointmentRepository;
        private IAppointmentDetailRepository _appointmentDetailRepository;
        public AppointmentService(IAppointmentRepository appointmentRepository, IAppointmentDetailRepository appointmentDetailRepository)
        {
            _appointmentRepository = appointmentRepository;
            _appointmentDetailRepository = appointmentDetailRepository;
        }

        public IEnumerable<AppointmentViewModel> GetAppointments(string Id)
        {
            return _appointmentRepository.GetAppointments(Id);
        }

        public IEnumerable<AppointmentViewModel> GetAppointmentsById(long id)
        {
            return _appointmentRepository.GetAppointmentsById(id);
        }

        public IEnumerable<AppointmentViewModel> GetAppointmentsByStatus(EntityHelper.AppointmentStatus status)
        {
            return _appointmentRepository.GetAppointmentsByStatus(status);
        }
        public string Booking(BookingViewModel booking)
        {
            try
            {
                long id = _appointmentRepository.AddNewAppointment(booking);
                _appointmentDetailRepository.AddAppointmentDetail(booking, id);
                return "Succeeded";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public IEnumerable<AppointmentDetailModelView> GetAppointmentDetails(int appointmentId)
        {
            return _appointmentDetailRepository.GetAppointmentDetails(appointmentId);
        }
    }
}
