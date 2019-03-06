using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SPA_Application.Common;
using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using SPA_Application.Infrastructure.Context;
using SPA_Application.Infrastructure.Repository.IRepository;
using static SPA_Application.Common.EntityHelper;

namespace SPA_Application.Infrastructure.Repository.Repository
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private SPAContext _context;

        public AppointmentRepository(SPAContext context)
        {
            _context = context;
        }
        public IEnumerable<AppointmentViewModel> GetAppointments(string Id)
        {
            var history = _context.Appointments.Where(p => p.UserId == Id).Select(p => new AppointmentViewModel
            {
                Id = p.Id,
                DateBooked = p.DateBooked,
                TotalTime = p.TotalTime,
                TotalPrice = p.TotalPrice,
                ExtraNote = p.ExtraNote,
                IsPaid = p.IsPaid,
                Status = p.Status,
                OutletName = _context.Outlets.Where(t => t.Id == p.OutletId).Select(t => t.Name).FirstOrDefault(),
                TherapistName = _context.Users.Where(t => t.Id == p.TherapistId).Select(t => t.FullName).FirstOrDefault()
            }).ToList();
            return history;
        }

        public IEnumerable<AppointmentViewModel> GetAppointmentsById(long id)
        {
            return _context.Appointments.Where(p => p.Id == id).Select(p => new AppointmentViewModel
            {
                Id=p.Id,
                DateBooked=p.DateBooked,
                TotalTime=p.TotalTime,
                TotalPrice=p.TotalPrice,
                ExtraNote=p.ExtraNote,
                IsPaid=p.IsPaid,
                Status=p.Status //fixed

            }).ToList();
        }

     


        //FIX LỖI Ở APPOINTMENTSTATUS DÙM. KHÔNG THỂ GỌI RA ĐƯỢC
        public IEnumerable<AppointmentViewModel> GetAppointmentsByStatus(EntityHelper.AppointmentStatus status)
        {
            return _context.Appointments.Where(p => p.Status == status).Select(p => new AppointmentViewModel
            {
                Id = p.Id,
                DateBooked = p.DateBooked,
                TotalTime = p.TotalTime,
                TotalPrice = p.TotalPrice,
                ExtraNote = p.ExtraNote,
                IsPaid = p.EntityStatus,
                Status = p.Status

            }).ToList();
        }

        public long AddNewAppointment(BookingViewModel booking)
        {
            Appointment appointment = new Appointment
            {
                DateBooked = booking.DatetimeBooked,
                OutletId = booking.OutletId,
                UserId = booking.UserId,
                TotalPrice = booking.TotalPrice,
                TotalTime = booking.TotalTime,
                TherapistId = booking.Therapit
            };
            appointment.AddEntity();
            var result = _context.Appointments.AddAsync(appointment).Result;
            _context.SaveChanges();
            return _context.Appointments.OrderByDescending(p => p.Id).Select(p => p.Id).FirstOrDefault();
        }

    }
}
