using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SPA_Application.Common;
using SPA_Application.Domains.Service.IService;
using SPA_Application.Domains.ViewModel;

namespace SPA_Application.Controllers.FeatureControllers
{
    [Route("api/[controller]")]
    public class AppointmentController : Controller
    {
        private IAppointmentService _appointmentService;

        public AppointmentController(IAppointmentService appointmentService)
        {
            _appointmentService = appointmentService;
        }

        [Route("history")]
        [HttpGet]
        public IActionResult GetAppointment(string userId)
        {
            try
            {
                return Ok(_appointmentService.GetAppointments(userId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("detail")]
        [HttpGet]
        public IActionResult GetAppointmentDetail(int appointmentId)
        {
            try
            {
                return Ok(_appointmentService.GetAppointmentDetails(appointmentId));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [Route("appointmentid")]
        [HttpGet]
        public IActionResult GetAppointmentById(long id)
        {
            try
            {
                return Ok(_appointmentService.GetAppointmentsById(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("statusappointment")]
        [HttpGet]
        public IActionResult GetAppointmentByStatus(EntityHelper.AppointmentStatus status)
        {
            try
            {

                return Ok(_appointmentService.GetAppointmentsByStatus(status));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Route("booking")]
        [HttpPost]
        public IActionResult BookingApppointment([FromBody]BookingViewModel model)
        {
            model.DatetimeBooked = model.DatetimeBooked.AddHours(7);
            string result = _appointmentService.Booking(model);
            return Ok();
        }

    }
}