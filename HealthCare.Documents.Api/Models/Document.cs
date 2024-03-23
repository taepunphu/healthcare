using System.ComponentModel.DataAnnotations.Schema;
using HealthCare.SharedAssets;

namespace HealthCare.Documents.Api.Models
{
    [Table("documents")]
    public class Document : BaseEntity<Guid>
    {
        public Document(Guid id, Guid patientId, string name, string path)
        {
            Id = id;
            PatientId = patientId;
            Path = path;
            Name = name;
        }

        [Column("patient_id")]
        public Guid PatientId { get; private set; }

        [Column("name")]
        public string Name { get; private set; }

        [Column("path")]
        public string Path { get; private set; }
    }
}