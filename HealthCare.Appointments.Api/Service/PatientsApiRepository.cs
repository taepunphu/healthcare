using System.Text.Json;
using HealthCare.Appointments.Api.Models;

namespace HealthCare.Appointments.Api.Service
{
    public class PatientsApiRepository(HttpClient httpClient) : IPatientsApiRepository
    {
        private readonly HttpClient _httpClient = httpClient;
        public async Task<Patient> GetPatient(Guid id)
        {
            var response = await _httpClient.GetAsync($"api/patients/{id}");

            response.EnsureSuccessStatusCode(); 

            using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<Patient>(responseStream);
        }

        public async Task<List<Patient>> GetPatients()
        {
            var response = await _httpClient.GetAsync("api/patients");

            response.EnsureSuccessStatusCode();

            using var responseStream = await response.Content.ReadAsStreamAsync();
            return await JsonSerializer.DeserializeAsync<List<Patient>>(responseStream);
        }
    }
}