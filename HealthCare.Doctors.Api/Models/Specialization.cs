using HealthCare.SharedAssets;

namespace HealthCare.Doctors.Api.Models
{
    public class Specialization : BaseEntity<int>
    {
        public string Name {get; set;} = string.Empty;
    }
}