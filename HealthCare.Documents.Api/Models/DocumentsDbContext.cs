using Microsoft.EntityFrameworkCore;

namespace HealthCare.Documents.Api.Models
{
    public class DocumentsDbContext : DbContext
    {
        public DocumentsDbContext(DbContextOptions<DocumentsDbContext> options) : base(options)
        {
        }

        public DbSet<Document> Documents { get; set; }
    }
}