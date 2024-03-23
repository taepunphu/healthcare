using HealthCare.SharedAssets;

namespace HealthCare.Appointments.Api.Models
{
    public class Patient : BaseEntity<Guid>
    {
        public Patient(string name, string sex, int? primaryDoctorId = null)
        {
            Name = name;
            Sex = sex;
            PreferredDoctorId = primaryDoctorId;
        }

        public Patient(Guid id)
        {
            Id = id;
        }

        private Patient()
        {
        }

        public string Name { get; private set; } = string.Empty;
        public string Sex {get; private set;} = string.Empty;
        public int? PreferredDoctorId { get; private set; }

        public void UpdateName(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name.ToString();
        }
    }
}