namespace HealthCare.Appointments.Api.Constants
{
    public class ApiEndpoints
    {
        private readonly IConfiguration _configuration;

        public ApiEndpoints(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private const string Doctors = "/doctors";
        private const string Patients = "/patients";

        public string GetDoctorsEndpoint() => $"{_configuration["ApiEndpoints:PatientsApi"]}{Doctors}";
        public string GetPatientsEndpoint() => $"{_configuration["ApiEndpoints:PatientsApi"]}{Patients}";
    }
}