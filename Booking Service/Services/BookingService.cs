using System.Collections.Generic;
using Booking_Service.Data;
using Booking_Service.Models;

namespace Booking_Service.Services
{
    public class BookingService : IBookingService
    {
        private readonly BookingMockDataService _bookingDataService;

        public BookingService(BookingMockDataService bookingDataService)
        {
            _bookingDataService = bookingDataService;
        }

        public void CreateAppointment(Appointment appointment)
        {
            _bookingDataService.AddAppointment(appointment);
        }

        public Appointment GetAppointmentById(int id)
        {
            return _bookingDataService.GetAppointmentById(id);
        }

        public List<Appointment> GetAllAppointments()
        {
            return _bookingDataService.GetAllAppointments();
        }

        public void UpdateAppointment(Appointment appointment)
        {
            _bookingDataService.UpdateAppointment(appointment);
        }

        public void DeleteAppointment(int id)
        {
            _bookingDataService.DeleteAppointment(id);
        }
    }
}
