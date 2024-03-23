using System.Diagnostics.CodeAnalysis;

namespace HealthCare.Appointments.Api.Service
{
    public class HttpRepository<T>(HttpClient client) : IHttpRepository<T> where T : class
    {
        private readonly HttpClient _client = client;

        public async Task DeleteAsync(string url, string id)
        {
            await _client.DeleteAsync($"{url}/{id}");
        }

        public async Task<T> GetAsync(string url, string id)
        {
            return await _client.GetFromJsonAsync<T>($"{url}/{id}");
        }

        public async Task<List<T>> GetAllAsync(string url)
        {
            return await _client.GetFromJsonAsync<List<T>>($"{url}");
        }

        public async Task<T> GetDetailsAsync(string url, string id)
        {
            return await _client.GetFromJsonAsync<T>($"{url}/{id}/details");
        }

        public async Task UpdateAsync(string url, T obj, string id)
        {
            await _client.PutAsJsonAsync($"{url}/{id}", obj);
        }
    }
}