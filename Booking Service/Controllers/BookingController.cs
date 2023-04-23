using System.Collections.Generic;
using Booking_Service.Models;
using Booking_Service.Services;
using Microsoft.AspNetCore.Mvc;

namespace Booking_Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingController(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        // GET: api/<BookingController>
        [HttpGet]
        public IEnumerable<Appointment> GetAllAppointments()
        {
            return _bookingService.GetAllAppointments();
        }

        // GET api/<BookingController>/5
        [HttpGet("{id}")]
        public ActionResult<Appointment> GetAppointmentById(int id)
        {
            var appointment = _bookingService.GetAppointmentById(id);
            if (appointment == null)
            {
                return NotFound();
            }
            return appointment;
        }

        // POST api/<BookingController>
        [HttpPost]
        public ActionResult<Appointment> CreateAppointment([FromBody] Appointment appointment)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _bookingService.CreateAppointment(appointment);
            return CreatedAtAction(nameof(GetAppointmentById), new { id = appointment.AppointmentId }, appointment);
        }

        // PUT api/<BookingController>/5
        [HttpPut("{id}")]
        public IActionResult UpdateAppointment(int id, [FromBody] Appointment appointment)
        {
            if (id != appointment.AppointmentId)
            {
                return BadRequest();
            }
            _bookingService.UpdateAppointment(appointment);
            return NoContent();
        }

        // DELETE api/<BookingController>/5
        [HttpDelete("{id}")]
        public IActionResult DeleteAppointment(int id)
        {
            var appointmentToDelete = _bookingService.GetAppointmentById(id);
            if (appointmentToDelete == null)
            {
                return NotFound();
            }
            _bookingService.DeleteAppointment(id);
            return NoContent();
        }
    }
}
