using System.ComponentModel.DataAnnotations.Schema;
using HealthCare.SharedAssets;

namespace HealthCare.Patients.Api.Models
{
    [Table("documents")]
    public class Document : BaseEntity<Guid>
    {
        
    }
}