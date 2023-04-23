using System;

namespace Booking_Service.Models
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public int DoctorId { get; set; }
        public DateTime AppointmentTime { get; set; }
        public int AppointmentDuration { get; set; }
        public string AppointmentStatus { get; set; }
        public string PaymentStatus { get; set; }
        public string Notes { get; set; }
    }
}
