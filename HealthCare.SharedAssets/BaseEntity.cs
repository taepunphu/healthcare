using System.ComponentModel.DataAnnotations.Schema;

namespace HealthCare.SharedAssets
{
    public abstract class BaseEntity<TId>
    {
        [Column("id")]
        public TId Id { get; set; }  
    }
}