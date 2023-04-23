using System.Collections.Generic;
using Booking_Service.Models;

namespace Booking_Service.Services
{
    public interface IBookingService
    {
        void CreateAppointment(Appointment appointment);
        Appointment GetAppointmentById(int id);
        List<Appointment> GetAllAppointments();
        void UpdateAppointment(Appointment appointment);
        void DeleteAppointment(int id);
    }
}
