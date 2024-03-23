using HealthCare.SharedAssets;

namespace HealthCare.Doctors.Api.Models
{
    public class Doctor(string name) : BaseEntity<Guid>
    {
        public string Name { get; private set; } = name;
        public int? SpecializationId { get; private set; }
        public Specialization? Specialization { get; private set; }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}