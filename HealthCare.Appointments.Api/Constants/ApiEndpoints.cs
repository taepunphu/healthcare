namespace HealthCare.Appointments.Api.Constants
{
    public class ApiEndpoints
    {
        private readonly IConfiguration _configuration;
        private const string Doctors = "/doctors";
        private const string Patients = "/patients";
        public ApiEndpoints(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public string GetDoctorsEndpoint()
        {
            return _configuration["ApiEndpoints:DoctorsApi"] + Doctors;
        }

        public string GetPatientsEndpoint()
        {
            return _configuration["ApiEndpoints:PatientsApi"] + Patients;
        }
    }
}