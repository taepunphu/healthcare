using System.ComponentModel.DataAnnotations.Schema;
using HealthCare.SharedAssets;

namespace HealthCare.Patients.Api.Models
{
    [Table("patients")]
    public class Patient : BaseEntity<Guid>
    {
        public Patient()
        {

        }

        [Column("first_name")]
        public string FirstName { get; set; }

        [Column("last_name")]
        public string LastName { get; set; }

        [Column("date_of_birth")]
        public DateTime DateOfBirth { get; set; }
        public List<Document> Documents { get; set; } = new List<Document>();
    }
}