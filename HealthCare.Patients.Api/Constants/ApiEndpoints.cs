namespace HealthCare.Patients.Api.Constants
{
    public class ApiEndpoints(IConfiguration configuration)
    {
        private readonly IConfiguration _configuration = configuration;
        private const string Documents = "/documents";
        private const string Patients = "/patients";
        private const string Doctors = "/doctors";

        public string GetDocumentsApi => $"{_configuration["ApiEndpoints:DocumentsApi"]}{Documents}";
        public string GetDoctorsApi => $"{_configuration["ApiEndpoints:DoctorsApi"]}{Doctors}";
        public string GetPatientsApi => $"{_configuration["ApiEndpoints:PatientsApi"]}{Patients}";
    }
}