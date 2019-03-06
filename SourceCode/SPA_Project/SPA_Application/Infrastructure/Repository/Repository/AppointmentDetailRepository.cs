using SPA_Application.Domains.Entity;
using SPA_Application.Domains.ViewModel;
using SPA_Application.Infrastructure.Context;
using SPA_Application.Infrastructure.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SPA_Application.Infrastructure.Repository.Repository
{
    public class AppointmentDetailRepository : IAppointmentDetailRepository
    {
        private SPAContext _context;

        public AppointmentDetailRepository(SPAContext context)
        {
            _context = context;
        }

        public void AddAppointmentDetail(BookingViewModel booking, long appointmentId)
        {
            DateTime startTime = booking.DatetimeBooked;
            DateTime endTime;
            for (int i=0; i < booking.Services.Count; i++)
            {
                var bedId = _context.Beds.Where(p => p.Status == 0).Select(p => p.Id).FirstOrDefault();
                int time = _context.Services.Where(p => p.Id == booking.Services[i]).Select(p => p.Time).First();
                endTime = startTime.AddMinutes(time);
                AppointmentDetail detail = new AppointmentDetail
                {
                    AppointmentId = appointmentId,
                    ServiceId = booking.Services[i],
                    Order = i + 1,
                    StartTime = startTime,
                    FinishTime = endTime,
                    BedId = bedId
                };
                detail.AddEntity();

                var result = _context.AppointmentDetails.AddAsync(detail).Result;
                startTime = endTime;
            }
            _context.SaveChanges();
            //return "Succeed";
        }

        public IEnumerable<AppointmentDetailModelView>GetAppointmentDetails(int appointmentId)
        {
            var list = _context.AppointmentDetails.Where(p => p.AppointmentId == appointmentId).Select(p => new AppointmentDetailModelView{
                ServiceName = _context.Services.Where(t=>t.Id == p.ServiceId).Select(t=>t.ServiceName).FirstOrDefault(),
                FinishTime = p.FinishTime,
                StartTime=p.StartTime,
                Order = p.Order
            }).ToList();
            return list;
        }
    }
}
