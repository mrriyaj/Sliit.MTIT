using System.Collections.Generic;
using System.Linq;
using Booking_Service.Models;

namespace Booking_Service.Data
{
    public class BookingMockDataService
    {
        private readonly List<Appointment> _appointments = new List<Appointment>()
        {
            new Appointment { AppointmentId = 1, PatientId = 1, DoctorId = 1, AppointmentTime = new System.DateTime(2023, 05, 01, 09, 00, 00), AppointmentDuration = 60, AppointmentStatus = "Scheduled", PaymentStatus = "Pending", Notes = "New patient" },
            new Appointment { AppointmentId = 2, PatientId = 2, DoctorId = 1, AppointmentTime = new System.DateTime(2023, 05, 02, 14, 30, 00), AppointmentDuration = 30, AppointmentStatus = "Scheduled", PaymentStatus = "Paid", Notes = "Follow-up visit" },
            new Appointment { AppointmentId = 3, PatientId = 3, DoctorId = 2, AppointmentTime = new System.DateTime(2023, 05, 03, 11, 15, 00), AppointmentDuration = 45, AppointmentStatus = "Cancelled", PaymentStatus = "Refunded", Notes = "Sick visit" },
            new Appointment { AppointmentId = 4, PatientId = 4, DoctorId = 2, AppointmentTime = new System.DateTime(2023, 05, 04, 10, 00, 00), AppointmentDuration = 60, AppointmentStatus = "Scheduled", PaymentStatus = "Pending", Notes = "New patient" }
        };

        public void AddAppointment(Appointment appointment)
        {
            int newId = _appointments.Count > 0 ? _appointments.Max(a => a.AppointmentId) + 1 : 1;
            appointment.AppointmentId = newId;
            _appointments.Add(appointment);
        }

        public Appointment GetAppointmentById(int id)
        {
            return _appointments.FirstOrDefault(a => a.AppointmentId == id);
        }

        public List<Appointment> GetAllAppointments()
        {
            return _appointments;
        }

        public void UpdateAppointment(Appointment appointment)
        {
            var existingAppointment = _appointments.FirstOrDefault(a => a.AppointmentId == appointment.AppointmentId);
            if (existingAppointment != null)
            {
                existingAppointment.PatientId = appointment.PatientId;
                existingAppointment.DoctorId = appointment.DoctorId;
                existingAppointment.AppointmentTime = appointment.AppointmentTime;
                existingAppointment.AppointmentDuration = appointment.AppointmentDuration;
                existingAppointment.AppointmentStatus = appointment.AppointmentStatus;
                existingAppointment.PaymentStatus = appointment.PaymentStatus;
                existingAppointment.Notes = appointment.Notes;
            }
        }

        public void DeleteAppointment(int id)
        {
            var appointmentToDelete = _appointments.FirstOrDefault(a => a.AppointmentId == id);
            if (appointmentToDelete != null)
            {
                _appointments.Remove(appointmentToDelete);
            }
        }
    }
}
