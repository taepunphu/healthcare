namespace HealthCare.Appointments.Api.Dtos
{
    public class AppointmentDetailsDto
    {
        public required PatientDto Patient { get; set; }
        public Guid PatientId { get; set; }
        public required DoctorDto Doctor { get; set; }
        public Guid DoctorId { get; set; }
        public int AppointmentTypeId { get; set; }

        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Title { get; set; } = string.Empty;
        public DateTime? DateTimeConfirmed { get; set; }
    }
}