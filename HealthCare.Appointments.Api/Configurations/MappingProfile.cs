using AutoMapper;
using HealthCare.Appointments.Api.Dtos;
using HealthCare.Appointments.Api.Models;

namespace HealthCare.Appointments.Api.Configurations
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Doctor, DoctorDto>();
            CreateMap<Patient, PatientDto>();
            CreateMap<Appointment, AppointmentDetailsDto>();
        }
    }
}