namespace HealthCare.Appointments.Api.Service
{
    public interface IHttpRepository<T> where T : class
    {
        Task<T> GetAsync(string url, string id);
        Task<T> GetDetailsAsync(string url, string id);
        Task<List<T>> GetAllAsync(string url);
        Task UpdateAsync(string url, T obj, string id);
        Task DeleteAsync(string url, string id);
    }
}